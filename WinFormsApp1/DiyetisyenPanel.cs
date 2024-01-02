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

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

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

        private void populateItems()
        {
            using (baglanti)
            {
                baglanti.Open();

                string query = "SELECT * FROM Partner";
                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    using SqlDataReader dataReader = command.ExecuteReader();
                    {
                        while (dataReader.Read())
                        {
                            //DietitianItem dietitianItem = new DietitianItem(dataReader["consultant"]);
                        }
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

            using(baglanti)
            {
                baglanti.Open();

                string query = $"SELECT * FROM UpdateTbl WHERE userId = @id ORDER BY updateTime ASC";

                using(SqlCommand command = new SqlCommand(query,baglanti)) 
                {
                    command.Parameters.AddWithValue("")
                }
            }
        }
    }
}