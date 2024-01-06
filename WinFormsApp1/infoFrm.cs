using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class infoFrm : Form
    {
        public int Id;
        public infoFrm(int id)
        {
            InitializeComponent();
            LoadDietitianData(this.Id = id);
        }
        SqlConnection baglanti = new SqlConnection(@"       ");

        private void infoFrm_Load(object sender, EventArgs e)
        {

        }
        private void LoadDietitianData(int id)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            using (baglanti) // connectionString'i uygun şekilde değiştirin
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Dietitian where dietitianId=@p1 ", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                using (SqlDataReader dataReader = komut.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string name = dataReader["nameSurname"].ToString();
                            lblName.Text = name;
                            string egitim = dataReader["education"].ToString();
                            lblEgitim.Text = egitim;
                            string univeriste = dataReader["university"].ToString();
                            lblUniversite.Text = univeriste;
                            string uzmanlik = dataReader["specialization"].ToString();
                            lblUzmanlik.Text = uzmanlik;

                        }
                    }
                    else
                    {
                        // Veri bulunamadıysa yapılacak işlemler
                        lblName.Text = "Veri bulunamadı";
                    }
                }

            }

            baglanti.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            DanisanPanel danisanPanelForm = Application.OpenForms.OfType<DanisanPanel>().FirstOrDefault();

            if (danisanPanelForm != null)
            {
                // DanisanPanel formu açık ise, Partner tablosuna giriş yap
                int consultantId = danisanPanelForm.Id;
                int dietitianId = this.Id; // infoFrm'nin dietitianId'si

                // Check if a record already exists for the specified consultant in the Partner table
                if (RecordExistsInPartnerTable(consultantId))
                {
                    // If a record exists, display a warning message
                    MessageBox.Show("Bu danışan zaten bir diyetisyene atanmış.");
                }
                else
                {
                    // If no record exists, add a new record to the Partner table
                    AddToPartnerTable(consultantId, dietitianId);
                    danisanPanelForm.UpdateDietitianInfo(dietitianId);

                    // İşlem başarılı mesajı

                }
            }
            else
            {
                // DanisanPanel formu kapalı ise uyarı ver
                MessageBox.Show("DanisanPanel formu bulunamadı.");
            }
        }

        // Helper method to check if a record already exists for the specified consultant in the Partner table
        private bool RecordExistsInPartnerTable(int consultantId)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();

                // Check if a record already exists for the specified consultant in the Partner table
                string query = "SELECT COUNT(*) FROM Partner WHERE consultant = @consultantId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@consultantId", consultantId);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void AddToPartnerTable(int consultantId, int dietitianId)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();

                // Partner tablosuna giriş yap
                string query = "INSERT INTO Partner (consultant, dietitian) VALUES (@consultantId, @dietitianId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@consultantId", consultantId);
                    command.Parameters.AddWithValue("@dietitianId", dietitianId);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}