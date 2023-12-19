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
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

        private void infoFrm_Load(object sender, EventArgs e)
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
    }
}
