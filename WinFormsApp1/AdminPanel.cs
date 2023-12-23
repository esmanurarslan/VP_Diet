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

namespace WinFormsApp1
{
    public partial class AdminPanel : Form
    {
        public int Id;
        public AdminPanel(int id)
        {
            InitializeComponent();
            LoadUserStatistics(this.Id = id);
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        //SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");
        private void AdminPanel_Load(object sender, EventArgs e)
        {

            LoadDietStatistics();
            LoadConsultantStatistics();
            populateDietitiansItems();
            populateConsultantItems();

            foreach (var listItemControl in flowLayoutPanel1.Controls)
            {
                if (listItemControl is listItem listItem)
                {
                    listItem.btnInceleClicked += ListItem_InceleClicked;
                }
            }

            foreach (var listItemControl in flowLayoutPanel2.Controls)
            {
                if (listItemControl is ConsultantItem consultantItem)
                {
                    consultantItem.InceleClicked += ListItem_InceleClicked2;
                }
            }
        }

        private void LoadUserStatistics(int id)
        {
            try
            {
                baglanti.Open();

                using (SqlCommand komut1 = new SqlCommand("SELECT * FROM Users WHERE Id = @id", baglanti))
                {
                    komut1.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader2 = komut1.ExecuteReader())
                    {
                        if (dataReader2.Read())
                        {
                            string kullaniciAdi = dataReader2["userName"].ToString();
                            lblAdmin.Text = kullaniciAdi;

                        }
                    }
                }

                // Toplam kullanıcı sayısı
                SqlCommand cmdTotalUser = new SqlCommand("SELECT COUNT(*) FROM Users where userType in(2,3)", baglanti);
                int totalUser = Convert.ToInt32(cmdTotalUser.ExecuteScalar());
                lblTotalUser.Text = totalUser.ToString();


                // Bugün kayıt olan kullanıcı sayısı
                SqlCommand cmdUserToday = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int userToday = Convert.ToInt32(cmdUserToday.ExecuteScalar());
                lblUserToday.Text = userToday.ToString();

                // Son bir haftada kayıt olan kullanıcı sayısı
                SqlCommand cmdUserWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int userWeek = Convert.ToInt32(cmdUserWeek.ExecuteScalar());
                lblUserWeek.Text = userWeek.ToString();

                // Son bir ayda kayıt olan kullanıcı sayısı
                SqlCommand cmdUserMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int userMonth = Convert.ToInt32(cmdUserMonth.ExecuteScalar());
                lblUserMonth.Text = userMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LoadDietStatistics()
        {
            try
            {
                baglanti.Open();

                // Diyet toplam sayısı
                SqlCommand cmdDietTotal = new SqlCommand("SELECT COUNT(*) FROM Users Where userType=2", baglanti);
                int dietTotal = Convert.ToInt32(cmdDietTotal.ExecuteScalar());
                lblDietTotal.Text = dietTotal.ToString();

                // Bugünkü diyet sayısı
                SqlCommand cmdDietDay = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int dietDay = Convert.ToInt32(cmdDietDay.ExecuteScalar());
                lblDietDay.Text = dietDay.ToString();

                // Son bir haftada eklenen diyet sayısı
                SqlCommand cmdDietWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int dietWeek = Convert.ToInt32(cmdDietWeek.ExecuteScalar());
                lblDietWeek.Text = dietWeek.ToString();

                // Son bir ayda eklenen diyet sayısı
                SqlCommand cmdDietMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int dietMonth = Convert.ToInt32(cmdDietMonth.ExecuteScalar());
                lblDietMonth.Text = dietMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LoadConsultantStatistics()
        {
            try
            {
                baglanti.Open();

                // Danışman toplam sayısı
                SqlCommand cmdConTotal = new SqlCommand("SELECT COUNT(*) FROM Users Where userType=3", baglanti);
                int conTotal = Convert.ToInt32(cmdConTotal.ExecuteScalar());
                lblConTotal.Text = conTotal.ToString();

                // Bugünkü danışman sayısı
                SqlCommand cmdConDay = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int conDay = Convert.ToInt32(cmdConDay.ExecuteScalar());
                lblConDay.Text = conDay.ToString();

                // Son bir haftada eklenen danışman sayısı
                SqlCommand cmdConWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int conWeek = Convert.ToInt32(cmdConWeek.ExecuteScalar());
                lblConWeek.Text = conWeek.ToString();

                // Son bir ayda eklenen danışman sayısı
                SqlCommand cmdConMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int conMonth = Convert.ToInt32(cmdConMonth.ExecuteScalar());
                lblConMonth.Text = conMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private List<string> GetDietitianUsernames()
        {
            List<string> usernames = new List<string>();

            try
            {
                // Veritabanına bağlantı sağla
                using (baglanti)
                {
                    baglanti.Open();

                    // SQL sorgusunu oluştur
                    string query = "SELECT nameSurname FROM Dietitian"; // DietitianTable tablosunda bulunan kullanıcı adlarını çek
                    using (SqlCommand command = new SqlCommand(query, baglanti))
                    {
                        // Veritabanından verileri oku
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string username = reader["nameSurname"].ToString();
                                usernames.Add(username);
                            }
                        }
                    }

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving dietitian usernames: " + ex.Message);
            }

            return usernames;
        }

        private void populateDietitiansItems()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost; Initial Catalog=VP_diet;Integrated Security=True");
            using (connection)
            {
                connection.Open();

                string query = "SELECT * FROM Users JOIN Dietitian ON Users.Id = Dietitian.dietitianId;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listItem listItem = new listItem(Convert.ToInt32(reader["dietitianId"]));
                            listItem.DietitianId = Convert.ToInt32(reader["dietitianId"]); // Bu satırın eklenmiş olması önemli
                            listItem.Name = reader["nameSurname"].ToString();
                            DateTime registerDate = Convert.ToDateTime(reader["registerDate"]);

                            // Gün sayısını hesaplayarak label'a atama yapın
                            TimeSpan difference = DateTime.Now - registerDate;
                            int gunSayisi = (int)difference.TotalDays;
                            listItem.Puan = gunSayisi.ToString() + " gündür üye";
                            listItem.InceleClicked += ListItem_InceleClicked;
                            flowLayoutPanel1.Controls.Add(listItem);
                        }
                    }
                }




            }
        }

        private void populateConsultantItems()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost; Initial Catalog=VP_diet;Integrated Security=True");
            using (connection)
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE userType=3";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int consultantId = Convert.ToInt32(reader["Id"]);
                            ConsultantItem consultantItem = new ConsultantItem(consultantId);
                            consultantItem.Username = reader["userName"].ToString();
                            DateTime registerDate = Convert.ToDateTime(reader["registerDate"]);

                            // Gün sayısını hesaplayarak label'a atama yapın
                            TimeSpan difference = DateTime.Now - registerDate;
                            int gunSayisi = (int)difference.TotalDays;
                            consultantItem.Gun = gunSayisi.ToString() + " gündür üye";

                            // Diğer özelliklere de değer atandığından emin olun
                            consultantItem.ConsultantId = consultantId;

                            consultantItem.InceleClicked += ListItem_InceleClicked2;
                            flowLayoutPanel2.Controls.Add(consultantItem);
                        }
                    }
                }
            }
        }

        private void ListItem_InceleClicked2(object? sender, int Id)
        {
            ConsultantInfoFromAdmin form = new ConsultantInfoFromAdmin(Id);
            form.Show();
        }

        private void ListItem_InceleClicked(object sender, int Id)
        {
            // InceleClicked etkinliği tetiklendiğinde infoFrm formunu aç
            dietitianInfoFromAdmin form = new dietitianInfoFromAdmin(Id);
            form.Show();
        }

        private void btnSayfaYenile_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel(Id);
            form.Show();
            this.Close();
        }



        private void btnParola_Click(object sender, EventArgs e)
        {

            PassUpdate frm = new PassUpdate(Id);
            this.Opacity = 0.5;
            frm.FormClosed += (s, args) =>
            {
                // Guncelle formu kapatıldığında ana formun saydamlığını 1.0 olarak ayarla
                this.Opacity = 1.0;
            };
            frm.Show();
        }
    }
}
