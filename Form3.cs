using System;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manavodev2
{
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;");
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // ToolTip'leri ayarla
            toolTip1.SetToolTip(adBox, "Adınızı Girin");
            toolTip1.SetToolTip(soyadBox, "Soyadınızı Girin.");
            toolTip1.SetToolTip(MailBox, "E-posta adresinizi girin");
  
            toolTip1.SetToolTip(cikBtn, "Giriş sayfasına dön.");
            toolTip1.SetToolTip(checkBox1, "Şifreyi göster/gizle.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            string email = MailBox.Text.Trim();
            string ad = adBox.Text.Trim();
            string soyad = soyadBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Tüm Boşlukları Doldurun");
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkEmailQuery = "SELECT COUNT(*) FROM Kullanıcılar WHERE mail = @mail";
                    OleDbCommand checkEmailCmd = new OleDbCommand(checkEmailQuery, conn);
                    checkEmailCmd.Parameters.AddWithValue("@mail", email);
                    int emailExists = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                    if (emailExists > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kayıtlı. Lütfen başka bir e-posta adresi kullanın.");
                        return;
                    }

                    MessageBox.Show("Doğrulama e-postası gönderildi.");

                    SendVerificationEmail(email, ad, soyad);
                    mailDogrulaPanel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

         }

        string dogrulamaKodu;
        public void SendVerificationEmail(string email, string ad,string soyad)
        {
    
            string verificationCode = ad.Substring(0, 3) + soyad.Substring(soyad.Length - 2) + "2025";

            MailMessage mail = new MailMessage("example@gmail.com", email);
            mail.Subject = "Hesap Doğrulama Kodu";
            mail.Body = $"Merhaba,\n\nDoğrulama kodunuz: {verificationCode}\n\nKodunuzu kullanarak şifrenizi belirleyebilirsiniz.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("yigitkuru064@gmail.com", "vqsl pdkd omnx kteu");
            smtp.EnableSsl = true;
            dogrulamaKodu = verificationCode;

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Doğrulama e-postası gönderildi.");
                mailDogrulaPanel.Visible = true;
                ShowPanelInCenter(mailDogrulaPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message);
                Console.WriteLine("Hata Detayı: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enteredCode = koddogrulaBox.Text;     
            string expectedCode = dogrulamaKodu;

            if (enteredCode == expectedCode)
            {
                MessageBox.Show("Kod doğru! Şifrenizi belirleyebilirsiniz.");
                ShowPasswordSetPage();
                ShowPanelInCenter(sifrebelirlePanel);
            }
            else
            {
                MessageBox.Show("Doğrulama kodu yanlış. Lütfen tekrar deneyin.");
            }
        }

        public void KullanıcıKaydet()
        {
            string ad = adBox.Text.Trim();
            string soyad = soyadBox.Text.Trim();
            string email = MailBox.Text.Trim();
            string sifre = sifreBox.Text.Trim();


            // Access veritabanı bağlantı dizesi (Yolu kendinize göre değiştirin)
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
               
                    string query = "INSERT INTO Kullanıcılar (ad, soyad, mail, sifre) VALUES (@ad, @Soyad, @mail, @sifre)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@sifre", sifre);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoMenu();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPasswordSetPage()
        {
            sifrebelirlePanel.Visible = true;
            mailDogrulaPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string password = sifreBox.Text;
            string confirmPassword = textBox7.Text;

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

            string username = adBox.Text;
     
                try
                {
                KullanıcıKaydet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            
        }


        private void ShowPanelInCenter(Panel panel)
        {
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        public void GoMenu()
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cikBtn_Click(object sender, EventArgs e)
        {
            GoMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
