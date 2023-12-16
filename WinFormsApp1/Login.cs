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

//Şevval's Database
//Data Source = LAPTOP - 9HENLSU2; Initial Catalog = VP_diet; Integrated Security = True; Encrypt = True; Trust Server Certificate=True

//esma db                     Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True
namespace WinFormsApp1
{
    public partial class FormGiris : System.Windows.Forms.Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = LAPTOP - 9HENLSU2; Initial Catalog = VP_diet; Integrated Security = True; Encrypt = True; TrustServerCertificate=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUye formUye = new FormUye();
            formUye.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Users where username=@p1 and password=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtParola.Text);
                SqlDataReader dataReader = komut.ExecuteReader();
                if (dataReader.Read())
                {
                    int userType = Convert.ToInt32(dataReader["userType"]);
               
                    switch (userType)
                    {
                        case 1:
                            AdminPanel formAdmin = new AdminPanel(); //new AdminPanel(id)
                            formAdmin.Show();
                            break;
                        case 2:
                            DiyetisyenPanel Diyetisyen = new DiyetisyenPanel(); //new DiyetisyenPanel(id);
                            Diyetisyen.Show();
                            break;
                        case 3:
                            int id = Convert.ToInt32(dataReader["Id"]);
                            DanisanPanel Danisan = new DanisanPanel(id);                   
                            Danisan.Show();
                            break;
                        default:
                            MessageBox.Show("Geçersiz userType değeri.");
                            break;
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("hatalı giriş!");
                }
            }
            baglanti.Close();
           

        }
    }
}
//Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True