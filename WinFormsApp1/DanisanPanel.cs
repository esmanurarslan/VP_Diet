using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Cryptography;





// Şevval's database
//Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True
//esma db   Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True


namespace WinFormsApp1
{
    public partial class DanisanPanel : Form
    {
        public int Id;
        private Panel myPanel;


        public DanisanPanel(int id)
        {
            InitializeComponent();
            //this.Id = id;
            DrawLineChart(this.Id = id, "newWeight", grafikPanel1);
            DrawLineChart(this.Id = id, "newWaist", grafikPanel2);
            DrawLineChart(this.Id = id, "newHip", grafikPanel3);
            DrawLineChart(this.Id = id, "newChest", grafikPanel4);
            LoadConsultantData(this.Id = id);
            // UpdateCompleted olayına abone ol
            UpdateKg updateKgForm = new UpdateKg(Id);
            updateKgForm.UpdateCompleted += UpdateKgForm_UpdateCompleted;

            foreach (var listItemControl in flowLayoutPanel1.Controls)
            {
                if (listItemControl is listItem listItem)
                {
                    listItem.btnInceleClicked += ListItem_InceleClicked;
                }
            }



        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void UpdateKgForm_UpdateCompleted(object sender, EventArgs e)
        {
            // Güncelleme tamamlandığında yapılacak işlemler
            LoadConsultantData(Id); // veya başka güncelleme işlemleri
        }
        private void LoadConsultantData(int id)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            using (baglanti) // connectionString'i uygun şekilde değiştirin
            {
                baglanti.Open();


                // 1. SqlCommand için SqlDataReader
                using (SqlCommand komut1 = new SqlCommand("SELECT * FROM Users WHERE Id = @id", baglanti))
                {
                    komut1.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader2 = komut1.ExecuteReader())
                    {
                        if (dataReader2.Read())
                        {
                            string kullaniciAdi = dataReader2["userName"].ToString();
                            lblUser.Text = kullaniciAdi;
                            DateTime registerDate = Convert.ToDateTime(dataReader2["registerDate"]);

                            // Gün sayısını hesaplayarak label'a atama yapın
                            TimeSpan difference = DateTime.Now - registerDate;
                            int gunSayisi = (int)difference.TotalDays;

                            lblGun.Text = gunSayisi.ToString();
                        }
                    }
                }

                // 2. SqlCommand için SqlDataReader
                using (SqlCommand komut2 = new SqlCommand("SELECT * FROM Consultant WHERE consultantId = @id", baglanti))
                {
                    komut2.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = komut2.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            string email = dataReader["email"].ToString();
                            lblMail.Text = email;
                            string boyy = dataReader["height"].ToString();
                            lblBoy.Text = boyy;
                            int boy1 = Convert.ToInt32(dataReader["height"]);
                            string target = dataReader["targetWeight"].ToString();
                            lblTarget.Text = target;


                        }
                    }
                }

                // 3. SqlCommand için SqlDataReader
                using (SqlCommand komut3 = new SqlCommand("SELECT TOP 1 * FROM UpdateTbl WHERE userId = @id ORDER BY updateTime DESC", baglanti))
                {
                    komut3.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader3 = komut3.ExecuteReader())
                    {
                        if (dataReader3.Read())
                        {
                            string newwWeight = dataReader3["newWeight"].ToString();
                            kiloLbl.Text = newwWeight;

                            string newWaist = dataReader3["newWaist"].ToString();
                            lblBel.Text = newWaist;

                            string newHip = dataReader3["newHip"].ToString();
                            lblKalca.Text = newHip;

                            string newChest = dataReader3["newChest"].ToString();
                            lblGogus.Text = newChest;


                        }
                    }
                }

                //4.SqlCommand için SqlDataReader
                using (SqlCommand komut4 = new SqlCommand("SELECT D.nameSurname AS DietitianNameSurname, D.email AS DietitianEmail FROM Partner P JOIN Dietitian D ON P.dietitian = D.dietitianId WHERE P.consultant = @id ", baglanti))
                {
                    komut4.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader4 = komut4.ExecuteReader())
                    {
                        if (dataReader4.Read())
                        {
                            string dietitianNameSurname = dataReader4["DietitianNameSurname"].ToString();
                            string dietitianEmail = dataReader4["DietitianEmail"].ToString();

                            // Elde edilen değerleri kullanabilirsiniz
                            diyetisyenLbl.Text = dietitianNameSurname;
                            diyetisyenMailLbl.Text = dietitianEmail;
                        }
                        else
                        {
                            // Belirtilen consultantId ile eşleşen bir kayıt bulunamadı
                            diyetisyenLbl.Text = "Eşleşen diyetisyen bulunamadı";
                            diyetisyenMailLbl.Text = "";
                        }
                    }
                }

                using (SqlCommand komut7 = new SqlCommand("SELECT TOP 1 U.newWeight, C.height FROM UpdateTbl U INNER JOIN Consultant C ON U.userId = C.consultantId WHERE U.userId = @id ORDER BY U.updateTime DESC", baglanti))
                {
                    komut7.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader7 = komut7.ExecuteReader())
                    {
                        if (dataReader7.Read())
                        {
                            double newWeight = Convert.ToDouble(dataReader7["newWeight"]);
                            double height = Convert.ToDouble(dataReader7["height"]) / 100;

                            // BMI hesapla ve göster
                            CalculateAndShowBMI(newWeight, height);
                        }

                    }

                }

                baglanti.Close();
            }
        }


        // Veritabanından diyetisyen kullanıcı adlarını getiren bir metod
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

        private void populateItems()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            using (connection)
            {
                connection.Open();

                string query = "SELECT * FROM Dietitian";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listItem listItem = new listItem(Convert.ToInt32(reader["dietitianId"]));
                            listItem.DietitianId = Convert.ToInt32(reader["dietitianId"]); // Bu satırın eklenmiş olması önemli
                            listItem.Name = reader["nameSurname"].ToString();
                            listItem.Puan = "";
                            listItem.InceleClicked += ListItem_InceleClicked;
                            flowLayoutPanel1.Controls.Add(listItem);
                        }
                    }
                }
            }

        }
        public void UpdateDietitianInfo(int dietitianId)

        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            using (SqlCommand komut4 = new SqlCommand("SELECT D.nameSurname AS DietitianNameSurname, D.email AS DietitianEmail FROM Partner P JOIN Dietitian D ON P.dietitian = D.dietitianId WHERE P.consultant = @id ", baglanti))
            {
                baglanti.Open();
                komut4.Parameters.AddWithValue("@id", Id);

                using (SqlDataReader dataReader4 = komut4.ExecuteReader())
                {
                    if (dataReader4.Read())
                    {
                        string dietitianNameSurname = dataReader4["DietitianNameSurname"].ToString();
                        string dietitianEmail = dataReader4["DietitianEmail"].ToString();

                        // Elde edilen değerleri kullanabilirsiniz
                        diyetisyenLbl.Text = dietitianNameSurname;
                        diyetisyenMailLbl.Text = dietitianEmail;
                    }
                    else
                    {
                        // Belirtilen consultantId ile eşleşen bir kayıt bulunamadı
                        diyetisyenLbl.Text = "Eşleşen diyetisyen bulunamadı";
                        diyetisyenMailLbl.Text = "";
                    }
                }
            }
        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanisanPanel form = new DanisanPanel(Id);
            form.Show();
            this.Close();
        }



        private void DanisanPanel_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void ListItem_InceleClicked(object sender, int dietitianId)
        {
            // InceleClicked etkinliği tetiklendiğinde infoFrm formunu aç
            infoFrm form = new infoFrm(dietitianId);
            form.Show();
        }

        private void CalculateAndShowBMI(double weight, double height)
        {
            // BMI hesapla
            double bmi = weight / (height * height);

            // BMI'ı ekrana yazdır
            lblBmi.Text = $"BMI: {bmi:F2}";

            // BMI değerlendirmesi
            if (bmi < 18.5)
            {
                lblBmi.Text += " (Zayıf)";
            }
            else if (bmi < 24.9)
            {
                lblBmi.Text += " (Normal)";
            }
            else if (bmi < 29.9)
            {
                lblBmi.Text += " (Fazla Kilolu)";
            }
            else
            {
                lblBmi.Text += " (Obez)";
            }
        }

        private string GetGraphTitle(string columnName)
        {
            // Eğer columnName "newWeight" ise "Kilo" olarak döndür
            if (columnName == "newWeight")
            {
                return "Kilo";
            }
            // Eğer columnName "newWaist" ise "Bel" olarak döndür
            else if (columnName == "newWaist")
            {
                return "Bel Ölçüsü";
            }
            // Eğer columnName "newHip" ise "Kalça" olarak döndür
            else if (columnName == "newHip")
            {
                return "Kalça Ölçüsü";
            }
            // Eğer columnName "newChest" ise "Göğüs" olarak döndür
            else if (columnName == "newChest")
            {
                return "Göğüs Ölçüsü";
            }
            // Diğer durumlar için columnName'i olduğu gibi kullan
            else
            {
                return columnName;
            }
        }

        private void DrawLineChart(int id, string columnName, Panel panel)
        {
            // Rastgele renkler oluşturmak için kullanılacak rastgele nesnesi
            Random random = new Random();

            // Rastgele bir renk oluşturun
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Chart kontrolü oluşturun
            Chart chart1 = new Chart();
            chart1.Size = new System.Drawing.Size(400, 300);

            // ChartArea oluşturun
            ChartArea chartArea = new ChartArea("ChartArea");

            // X ekseni etiket fontunu ayarlayın (yazı tipi ve boyutunu isteğinize göre değiştirebilirsiniz)
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 3); // Yazı boyutunu 6 olarak ayarladım, isteğinize göre değiştirin
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas.Add(chartArea);

            // Veri serisi oluşturun
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("MySeries");
            series.ChartType = SeriesChartType.Line;

            // Rastgele renk atayın
            series.Color = randomColor;

            // Seriyi grafiğe ekleyin
            chart1.Series.Add(series);
            //Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True
            //Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            using (baglanti)
            {
                baglanti.Open();

                string query = $"SELECT * FROM UpdateTbl WHERE userId = @id ORDER BY updateTime ASC";

                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    // @id parametresini eklemek için Parameters kullanılmalıdır.
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // SqlDataReader içinde veri okuma işlemleri
                        double xValue = 1;
                        while (reader.Read())
                        {
                            double yValue = Convert.ToDouble(reader[columnName]);

                            DataPoint point = new DataPoint(xValue, yValue);
                            point.Label = yValue.ToString(); // Y değeri etiket olarak ayarlanır
                            series.Points.Add(point);

                            xValue++; // X değerini artırmak için
                        }
                    }
                }
            }

            string graphTitle = GetGraphTitle(columnName);
            chart1.Titles.Add($"{graphTitle} Grafiği");

            panel.Controls.Add(chart1);

            // Chart kontrolünün boyutunu panelin boyutuna ayarlayın
            chart1.Dock = DockStyle.Fill;

            // Y eksenindeki etiketleri otomatik olarak belirleyin
            chartArea.AxisY.LabelStyle.Interval = double.NaN;
            chartArea.AxisY.LabelStyle.Enabled = true;

            // X ekseni minimumunu 1e ayarlayın
            chartArea.AxisX.Minimum = 0;

            // Markers ve Lines ekleyin
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.BorderWidth = 2;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnResetPassword_Click(object sender, EventArgs e)
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

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            UpdateKg frm = new UpdateKg(Id);
            this.Opacity = 0.5;
            frm.FormClosed += (s, args) =>
            {
                // Guncelle formu kapatıldığında ana formun saydamlığını 1.0 olarak ayarla
                //this.Update();
                this.Opacity = 1.0;

            };
            frm.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DanisanPanel form = new DanisanPanel(Id);
            form.Show();
            this.Close();

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {

            FormGiris frm = new FormGiris();

            this.Close();

            frm.Show();
        }

        private void cstmbtnsil_Click(object sender, EventArgs e)
        {
            // Kullanıcıya silme işlemini onaylamasını isteyen bir onay kutusu göster
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcı Evet'i seçerse silme işlemine devam et
            if (result == DialogResult.Yes)
            {

                //Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True
                //Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    connection.Open();

                    // Partner tablosundan kaydı silen SQL sorgusu
                    string deleteQuery = "DELETE FROM Partner WHERE consultant = @id";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", Id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                // Partner tablosundan kaydı sildikten sonra danışan panelini yeniden yükle
                LoadConsultantData(Id);


            }
        }

       
    }
}