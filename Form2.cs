using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manavodev2
{
    public partial class Form2 : Form
    {
        // Veritabanı bağlantısı için OleDbConnection nesnesi
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;");

        // ToolTip nesnesi, kullanıcıya bilgi vermek için kullanılır
        private ToolTip toolTip2 = new ToolTip();

        public Form2()
        {
            InitializeComponent();
            LoadRememberedUser(); // Daha önce hatırlanan kullanıcı bilgilerini yükle
        }

        // Form yüklendiğinde tool tip'leri ayarla
        private void Form2_Load(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre için tool tip'ler ayarlandı
            toolTip1.SetToolTip(textBox1, "E-posta giriniz");
            toolTip1.SetToolTip(textBox2, "Şifrenizi girin.");
            toolTip1.SetToolTip(button1, "Giriş yap.");
            toolTip1.SetToolTip(linkLabel2, "Kayıt ol.");
            toolTip1.SetToolTip(checkBoxRemember, "Bilgileri hatırla.");
            toolTip1.SetToolTip(linkLabel1, "Şifremi unuttum.");
        }

        // Giriş butonuna tıklanıldığında çalışacak metod
        private void button1_Click(object sender, EventArgs e)
        {
            // Textbox'lardan girilen verileri al
            string email = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            // Kullanıcı adı ve şifre boş veya varsayılan değer ise uyarı göster
            if (email == "Kullanıcı İsmi" || sifre == "Şifre" || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();
                    string query = "SELECT mail, [sifre] FROM Kullanıcılar WHERE mail = @mail"; // Kullanıcıyı sorgula
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@mail", email);

                    OleDbDataReader reader = command.ExecuteReader();

                    // Eğer kullanıcı adı doğru ise şifreyi kontrol et
                    if (reader.Read())
                    {
                        string dbPassword = reader["sifre"].ToString().Trim();

                        if (sifre == dbPassword)
                        {
                            MessageBox.Show("Başarıyla giriş yaptınız!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form4 form4 = new Form4();
                            form4.Show();
                            this.Hide(); // Şu anki formu gizle

                            // "Beni hatırla" kutusu işaretliyse bilgileri kaydet
                            if (checkBoxRemember.Checked)
                            {
                                Properties.Settings.Default.Email = email;
                                Properties.Settings.Default.Sifre = sifre;
                                Properties.Settings.Default.BeniHatırla = true;
                            }
                            else
                            {
                                // "Beni hatırla" kutusu işaretli değilse bilgileri temizle
                                Properties.Settings.Default.Email = "";
                                Properties.Settings.Default.Sifre = "";
                                Properties.Settings.Default.BeniHatırla = false;
                            }
                            Properties.Settings.Default.Save(); // Ayarları kaydet

                        }
                        else
                        {
                            MessageBox.Show("Şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Hata durumunda hata mesajını göster
                    MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapat
                }
            }
        }

        // Daha önce kaydedilen kullanıcı bilgilerini yükle
        private void LoadRememberedUser()
        {
            if (Properties.Settings.Default.BeniHatırla)
            {
                textBox1.Text = Properties.Settings.Default.Email;
                textBox2.Text = Properties.Settings.Default.Sifre;
                checkBoxRemember.Checked = true;
            }
        }

        // Kayıt olma bağlantısına tıklanıldığında yapılacak işlemler
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog(); // Kayıt olma formunu göster
            this.Show();
        }

        // Şifremi unuttum bağlantısına tıklanıldığında yapılacak işlemler
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form5().ShowDialog(); // Şifre sıfırlama formunu göster
            this.Hide();
        }

        // Çıkış butonuna tıklanıldığında uygulamayı kapat
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Uygulamayı sonlandır
        }

        // Hakkımızda menüsüne tıklanıldığında yapılacak işlemler
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog(); // Hakkımızda formunu göster
            this.Hide();
        }

        // Yardım menüsüne tıklanıldığında yapılacak işlemler
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog(); // Yardım formunu göster
            this.Hide();
        }
    }
}
