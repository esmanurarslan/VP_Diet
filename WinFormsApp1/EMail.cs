using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security;
using System.Security.Policy;


namespace WinFormsApp1
{
    public partial class EMail : Form
    {
        public EMail()
        {
            InitializeComponent();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();

            // SqlConnection nesnesini using bloğu içine al
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                // Users tablosundan şifreyi al
                using (SqlCommand komut = new SqlCommand("SELECT userName,password FROM Users WHERE email = @p1", baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", email);

                    using (SqlDataReader dataReader = komut.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            string password = dataReader.GetString(1);
                            string userName = dataReader.GetString(0);

                            // E-posta gönderme işlemini gerçekleştir
                            SendEmail(email, "Şifre Hatırlatma", $"Merhaba\nGaliba şifreni unuttun!\nSisteme kayıtlı kullanıcı adın:{userName}\nBuna göre Şifren: {password}\nSisteme giriş yaptıktan sonra şifreni güncellemeni tavsiye ederiz:)");

                            MessageBox.Show("Şifre e-posta ile gönderildi.");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }
                }
            }
        }

        private void SendEmail(string to, string subject, string body)
        {
            try
            {
                // E-posta gönderme işlemini gerçekleştirecek SMTP istemcisini oluştur
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("projectvisualprg@gmail.com", "rhucaiqdhpqznfen");
                    smtpClient.EnableSsl = true;

                    // E-posta mesajını oluştur
                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("projectvisualprg@gmail.com");
                        mailMessage.To.Add(to);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;

                        // E-posta gönder
                        smtpClient.Send(mailMessage);
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderirken bir hata oluştu: {ex.Message}");
            }
        }


    }

}
