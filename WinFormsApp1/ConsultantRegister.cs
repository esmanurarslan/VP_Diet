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
    public partial class FormDanisanUye : System.Windows.Forms.Form
    {
        public FormDanisanUye()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");





        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {/*
            baglanti.Open();
            // Diğer kontrollerinizi ekleyin (örneğin, boş kontrolü)
            SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM TblUsers WHERE username = @p16", baglanti);
            checkUsernameCommand.Parameters.AddWithValue("@p16", txtKullaniciAdi.Text);
            int existingUserCount = (int)checkUsernameCommand.ExecuteNonQuery();

            if (existingUserCount > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten var. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolalar eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    
                    SqlCommand komut = new SqlCommand("insert into TblUsers(username,password,email,userType) values(@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtParola.Text);
                    komut.Parameters.AddWithValue("@p3", txtMail.Text);
                    komut.Parameters.AddWithValue("@p4", 3);
                    komut.ExecuteNonQuery();

                    SqlCommand komut2 = new SqlCommand("insert into TblConsultant(username,birthDate,gender,city,country,currentWeight,targetWeight,height,waist,hip,chest,registerDate) values(@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", baglanti);
                    komut2.Parameters.AddWithValue("@p5", txtKullaniciAdi.Text);
                    komut2.Parameters.AddWithValue("@p6", txtDogumTarihi.Text);
                    komut2.Parameters.AddWithValue("@p7", cmbCinsiyet.SelectedItem.ToString());
                    komut2.Parameters.AddWithValue("@p8", txtSehir.Text);
                    komut2.Parameters.AddWithValue("@p9", txtUlke.Text);
                    komut2.Parameters.AddWithValue("@p10", Convert.ToInt32(txtMevcutKilo.Text));
                    komut2.Parameters.AddWithValue("@p11", Convert.ToInt32(txtHedefKilo.Text));
                    komut2.Parameters.AddWithValue("@p12", Convert.ToInt32(txtBoy.Text));
                    komut2.Parameters.AddWithValue("@p13", Convert.ToInt32(txtBel.Text));
                    komut2.Parameters.AddWithValue("@p14", Convert.ToInt32(txtKalca.Text));
                    komut2.Parameters.AddWithValue("@p15", Convert.ToInt32(txtGogus.Text));
                    komut2.Parameters.AddWithValue("@p16", DateTime.Now);
                    komut2.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Başarıyla yapıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormGiris formGiris = new FormGiris();
                    this.Hide();
                    formGiris.ShowDialog(); // Eğer modal bir pencere olarak açılmasını istiyorsanız ShowDialog() kullanabilirsiniz.
                    this.Close();

                    baglanti.Close();

            */


        }

    }
}




