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

namespace WinFormsApp1
{
    public partial class EMail : Form
    {
        public EMail()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

    } }
       /* private void btnGonder_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();

            // SqlConnection nesnesini using bloğu içine al
            using (SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True"))
            {
                baglanti.Open();

                // Diyetisyen tablosundan dietitianId'yi al
                using (SqlCommand komutDiet = new SqlCommand("SELECT dietitianId FROM Dietitian WHERE email = @p1", baglanti))
                {
                    komutDiet.Parameters.AddWithValue("@p1", email);

                    using (SqlDataReader dataReader = komutDiet.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            int dietitianId = dataReader.GetInt32(0); // dietitianId'yi al

                            // Users tablosundan şifreyi al
                            using (SqlCommand komutUser = new SqlCommand("SELECT password FROM Users WHERE id = @p2", baglanti))
                            {
                                komutUser.Parameters.AddWithValue("@p2", dietitianId);

                                using (SqlDataReader userReader = komutUser.ExecuteReader())
                                {
                                    if (userReader.Read())
                                    {
                                        string password = userReader.GetString(0);

                                        // E-posta gönderme işlemini gerçekleştir
                                        SendEmail(email, "Şifre Hatırlatma", $"Kullanıcı Adı: {email}\nŞifre: {password}");

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
                }
            }
        
    }

            private void SendEmail(string to, string subject, string body)
            {
                try
                {
                    // E-posta gönderme işlemini gerçekleştirecek SMTP istemcisini oluştur
                    using (SmtpClient smtpClient = new SmtpClient("projectvisualprg@gmail.com"))
                    {
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential("your-email@gmail.com", "your-password");
                        smtpClient.EnableSsl = true;

                        // E-posta mesajını oluştur
                        using (MailMessage mailMessage = new MailMessage())
                        {
                            mailMessage.From = new MailAddress("your-email@gmail.com");
                            mailMessage.To.Add(to);
                            mailMessage.Subject = subject;
                            mailMessage.Body = body;

                            // E-posta gönder
                            smtpClient.Send(mailMessage);
                        }
                    }

                    MessageBox.Show("E-posta başarıyla gönderildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"E-posta gönderirken bir hata oluştu: {ex.Message}");
                }
            }
        }
    } 
       */