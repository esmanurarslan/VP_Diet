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
    public partial class FormGiris : System.Windows.Forms.Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

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
           /* if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From TblUsers where username=@p1 and password=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtParola.Text);
                SqlDataReader dataReader = komut.ExecuteReader();
                if (dataReader.Read())
                {
                    int userType = Convert.ToInt32(dataReader["userType"]);

                    switch (userType)
                    {
                        case 1:
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.Show();
                            break;
                        case 2:
                            DiyetisyenPanel Diyetisyen = new DiyetisyenPanel();
                            Diyetisyen.Show();
                            break;
                        case 3:
                            DanisanPanel Danisan = new DanisanPanel();
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
           */

        }
    }
}
//Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True