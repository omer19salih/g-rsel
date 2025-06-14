using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manavodev2
{
    public partial class Form5 : Form
    {
      private string maildogrulamaKodu;

        public Form5()
        {
            InitializeComponent();
        }

        private void kodDogrulaBtn_Click(object sender, EventArgs e)
        {
            string girilenKod = kodDogrulaBox.Text;

            if (girilenKod != maildogrulamaKodu)
            {
                MessageBox.Show("Doğrulama kodu hatalı.");
                return;
            }
            else
            {
                MessageBox.Show("Kod Doğrulandı");
                sifreYenilePanel.Visible = true;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void sifreBelirleBtn_Click(object sender, EventArgs e)
        {
            string password = yenisifreBox.Text.Trim();
            string confirmPassword = sifreTekrarBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Lütfen şifre giriniz.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen kontrol edin.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.");
                return;
            }

            string email = mailDogrulaBox.Text.Trim();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Kullanıcılar SET [sifre] = @sifre WHERE [mail] = @mail";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sifre", password);
                        cmd.Parameters.AddWithValue("@mail", email);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Şifreniz başarıyla belirlendi. Giriş sayfasından giriş yapabilirsiniz.");
                           Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                            sifreYenilePanel.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Şifre Belirlenemedi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void mailDogrulamaBox_Click(object sender, EventArgs e)
        {
            string email = mailDogrulaBox.Text.Trim();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Kullanıcılar WHERE mail = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", email);

                        int userCount = (int)cmd.ExecuteScalar();
                        if (userCount == 0)
                        {
                            MessageBox.Show("Bu e-posta adresiyle kayıtlı bir kullanıcı bulunmamaktadır.");
                            return;
                        }
                    }
                   
                    Random rand = new Random();
                    maildogrulamaKodu = rand.Next(10000, 99999).ToString();

                    string subject = "Şifre Sıfırlama Kodu";
                    string body = $"Şifrenizi sıfırlamak için doğrulama kodunuz: {maildogrulamaKodu}";

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("yigitkuru064@gmail.com", "vqsl pdkd omnx kteu"),
                        EnableSsl = true
                    };

                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress("yigitkuru064@gmail.com"),
                        Subject = subject,
                        Body = body
                    };
                    mailMessage.To.Add(email);

                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Doğrulama kodu e-posta adresinize gönderildi.");
                    dogrulaPanel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("E-posta gönderilemedi: " + ex.Message);
                }
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

      
    }
    
}
