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
    public partial class ConsultantInfoFromAdmin : Form
    {
        public int Id;
        public ConsultantInfoFromAdmin(int id)
        {
            InitializeComponent();
            LoadDietitianData(this.Id = id);
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        //private object id;

        private void ConsultantInfoFromAdmin_Load(object sender, EventArgs e)
        {

        }
        private void LoadDietitianData(int id)
        {
            using (baglanti)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Consultant where consultantId=@p1 ", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                using (SqlDataReader dataReader = komut.ExecuteReader())
                {

                    dataReader.Read(); // Tek bir satır olduğunu varsayıyoruz
                    string email = dataReader["email"].ToString();
                    lblEmail.Text = email;
                    string gender = dataReader["gender"].ToString();
                    lblCinsiyet.Text = gender;
                    string city = dataReader["city"].ToString();
                    lblSehir.Text = city;

                }

                SqlCommand komut2 = new SqlCommand("SELECT D.nameSurname FROM Partner AS P JOIN Dietitian AS D ON P.dietitian = D.dietitianId WHERE P.consultant = @p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", id);
                using (SqlDataReader dataReader = komut2.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        // Veri bulundu, adını al ve lblDiyetisyen.Text'e ata
                        string name = dataReader["nameSurname"].ToString();
                        lblDiyetisyen.Text = name;
                    }
                    else
                    {
                        // Veri bulunamadı, "Diyetisyeni yok" mesajını ata
                        lblDiyetisyen.Text = "Diyetisyeni yok";
                    }
                }
            }

            baglanti.Close();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            // Kullanıcıya silme işlemini onaylamasını isteyen bir onay kutusu göster
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcı Evet'i seçerse silme işlemine devam et
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True"))
                    {
                        connection.Open();

                        // Users tablosundan kaydı silen SQL sorgusu
                        string deleteQuery = "DELETE FROM Consultant WHERE dietitianId = @id";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            // Id özelliğini kullan
                            deleteCommand.Parameters.AddWithValue("@id", Id);
                            deleteCommand.ExecuteNonQuery();
                        }
                        string deleteQuery2 = "DELETE FROM Users WHERE Id = @id";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery2, connection))
                        {
                            // Id özelliğini kullan
                            deleteCommand.Parameters.AddWithValue("@id", Id);
                            deleteCommand.ExecuteNonQuery();
                        }



                        connection.Close();
                    }

                    // Kayıt silindikten sonra bir mesaj göster
                    MessageBox.Show("Kayıt silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
