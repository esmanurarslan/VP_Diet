using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Windows.Forms.DataVisualization.Charting;
using MindFusion.Charting.WinForms;


namespace WinFormsApp1
{
    public partial class DiyetisyenPanel : Form
    {
        public int Id;
        public DiyetisyenPanel(int id)
        {
            InitializeComponent();
            LoadDietitianData(this.Id = id);

            foreach (var DietatianItemControl in flowLPnlCon.Controls)
            {
                if (DietatianItemControl is DietitianItem dietitianItem)
                {
                    dietitianItem.InspectClicked += DietitanItemBtn_Clicked;
                }
            }

            populateItems(this.Id = Id);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");

        //SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

        private void LoadDietitianData(int id)
        {

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
                            lblDietUserName.Text = kullaniciAdi;

                            string email = dataReader2["email"].ToString();
                            lblDietMail.Text = email;

                        }
                    }
                }

                using (SqlCommand komut2 = new SqlCommand("SELECT * FROM Dietitian WHERE dietitianId = @id", baglanti))
                {
                    komut2.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = komut2.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            string university = dataReader["university"].ToString();
                            lblDietSchool.Text = university;


                        }
                    }
                }

                using (SqlCommand komut3 = new SqlCommand("SELECT Count(*) FROM Partner WHERE dietitian= @id ", baglanti))
                {
                    komut3.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader3 = komut3.ExecuteReader())
                    {
                        if (dataReader3.Read())
                        {
                            int totalCon = Convert.ToInt32(dataReader3[0]); // Count(*) değerini alır
                            lblTotalCon.Text = totalCon.ToString();
                        }
                    }
                }

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

        private List<string> GetConsultantName()
        {
            List<string> consultantName = new List<string>();

            try
            {
                using (baglanti)
                {
                    baglanti.Open();

                    string query = "SELECT * FROM Users\r\nINNER JOIN Consultant ON Users.id = Consultant.consultantId\r\nINNER JOIN Dietitian ON Consultant.consultantId = Partner.consultant WHERE Partner.dietitian = @id;";
                    using (SqlCommand command = new SqlCommand(query, baglanti))
                    {
                        using SqlDataReader dataReader = command.ExecuteReader();
                        {
                            while (dataReader.Read())
                            {
                                string usernames = dataReader["userName"].ToString();
                                consultantName.Add(usernames);
                            }
                        }
                    }

                    baglanti.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            return consultantName;
        }

        private void populateItems(int id)
        {
            using (baglanti)
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");

                baglanti.Open();
                string query = "SELECT * FROM Users INNER JOIN Consultant ON Users.Id = Consultant.consultantId INNER JOIN Partner ON Consultant.consultantId = Partner.consultant WHERE Partner.dietitian = @id";

                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                        while (dataReader.Read())
                        {
                            DietitianItem dietitianItem = new DietitianItem(Convert.ToInt32(dataReader["consultantId"]));
                            dietitianItem.ConsultantId = Convert.ToInt32(dataReader["consultantId"]);
                            dietitianItem.Username = dataReader["userName"].ToString();
                            dietitianItem.Gender = dataReader["gender"].ToString();
                            dietitianItem.City = dataReader["city"].ToString();
                            dietitianItem.InspectClicked += DietitanItemBtn_Clicked;
                            flowLPnlCon.Controls.Add(dietitianItem);

                        }
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            PassUpdate resetPass = new PassUpdate(Id);

            this.Opacity = 0.5;
            resetPass.FormClosed += (s, args) =>
            {
                // Guncelle formu kapatıldığında ana formun saydamlığını 1.0 olarak ayarla
                this.Opacity = 1.0;
            };
            resetPass.Show();
        }

        private void Load_Graphics(int id, string columnName, Panel panel)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart.Size = new Size(300, 300);

            ChartArea chartArea = new ChartArea();

            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 4);
            chartArea.AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas.Add(chartArea);

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("MySeries");
            series.ChartType = SeriesChartType.Line;

            series.Color = randomColor;
            chart.Series.Add(series);

            using (baglanti)
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");

                baglanti.Open();

                string query = $"SELECT * FROM UpdateTbl WHERE userId = @id ORDER BY updateTime ASC";

                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        double xValue = 1;
                        while (reader.Read())
                        {
                            double yValue = Convert.ToDouble(reader[columnName]);

                            DataPoint point = new DataPoint(xValue, yValue);
                            point.Label = yValue.ToString();
                            series.Points.Add(point);

                            xValue++;

                        }

                    }
                }
            }
            string graphTitle = GetGraphTitle(columnName);
            chart.Titles.Add($"{graphTitle} Grafiği");

            panel.Controls.Add(chart);

            chart.Dock = DockStyle.Fill;

            chartArea.AxisY.LabelStyle.Interval = double.NaN;
            chartArea.AxisX.LabelStyle.Enabled = true;

            chartArea.AxisX.Minimum = 0;

            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.BorderWidth = 2;
        }

        private void DietitanItemBtn_Clicked(object sender, int consultantId)
        {


            Load_Graphics(this.Id = consultantId, "newWeight", pnlKilo);
            Load_Graphics(this.Id = consultantId, "newWaist", pnlBel);
            Load_Graphics(this.Id = consultantId, "newHip", pnlKalca);
            Load_Graphics(this.Id = consultantId, "newChest", pnlChest);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            FormGiris frm = new FormGiris();

            this.Close();

            frm.Show();

     
        }
    }
}