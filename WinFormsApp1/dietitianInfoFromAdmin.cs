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
    public partial class dietitianInfoFromAdmin : Form
    {
        public int Id;
        public dietitianInfoFromAdmin(int id)
        {
            InitializeComponent();
            LoadDietitianData(this.Id = id);
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        private object id;

        private void dietitianInfoFromAdmin_Load(object sender, EventArgs e)
        {

        }
        private void LoadDietitianData(int id)
        {
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



        private void deleteFromUsers()
        {

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
                        string deleteQuery = "DELETE FROM Dietitian WHERE dietitianId = @id";

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
    }
}
