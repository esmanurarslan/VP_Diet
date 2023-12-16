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
    public partial class UpdateKg : Form
    {
        public int Id;
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        //SqlConnection baglanti = new SqlConnection(@"/Data Source = LAPTOP - 9HENLSU2; Initial Catalog = VP_diet; Integrated Security = True; Encrypt = True; Trust Server Certificate=True");

        public UpdateKg(int id)
        {
            InitializeComponent();
            this.Id = id;
        }
        public event EventHandler UpdateCompleted;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateKg_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Id;
            using (baglanti)
            {
                baglanti.Open();
                string query = "INSERT INTO UpdateTbl (userId, newWeight, newWaist , newHip, newChest, updateTime) VALUES (@Id,@newWeight,@newWaist,@newHip,@newChest,@updateTime) ";
                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@newWeight", Convert.ToDouble(txtKiloUpdate.Text));
                    command.Parameters.AddWithValue("@newWaist", Convert.ToInt32(txtBelUpdate.Text));
                    command.Parameters.AddWithValue("@newHip", Convert.ToInt32(txtKAlcaUpdate.Text));

                    command.Parameters.AddWithValue("@newChest", Convert.ToInt32(txtGogusUpdate.Text));
                    command.Parameters.AddWithValue("@updateTime", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                UpdateCompleted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Güncelleme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            baglanti.Close();
            this.Close();

           // DanisanPanel frm = new DanisanPanel(Id);
            //frm.Show();

           
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
