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
//esma  Data Source = localhost; Initial Catalog = VP_diet; Integrated Security = True 
namespace WinFormsApp1
{
    public partial class FormDanisanUye : System.Windows.Forms.Form
    {
        public FormDanisanUye()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = localhost; Initial Catalog = VP_diet; Integrated Security = True");


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {// Kullanıcı adı ve şifre kontrolü
            if (txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = VP_diet; Integrated Security = True"))
            {
                connection.Open();

                // Kullanıcı adının zaten kullanılıp kullanılmadığını kontrol etme
                string checkUserNameQuery = "SELECT COUNT(*) FROM Users WHERE userName = @UserName";
                using (SqlCommand command = new SqlCommand(checkUserNameQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", txtKullaniciAdi.Text);
                    int existingUserCount = (int)command.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // E-posta adresinin zaten kullanılıp kullanılmadığını kontrol etme (Diyetisyen tablosunda)
                string checkEmailQuery = "SELECT COUNT(*) FROM Dietitian WHERE email = @Email";
                using (SqlCommand command = new SqlCommand(checkEmailQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", txtMail.Text);
                    int existingEmailCount = (int)command.ExecuteScalar();

                    if (existingEmailCount > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kullanılmış. Lütfen başka bir e-posta adresi kullanın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Users tablosuna kullanıcı ekleme
                string insertUserQuery = "INSERT INTO Users (userName, password, userType, registerDate) VALUES (@UserName, @Password, 3, @RegisterDate)";
                using (SqlCommand command = new SqlCommand(insertUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", txtKullaniciAdi.Text);
                    command.Parameters.AddWithValue("@Password", txtParola.Text);
                    command.Parameters.AddWithValue("@RegisterDate", DateTime.Now);
                    command.ExecuteNonQuery();
                }

                // Dietitian tablosuna diyetisyen ekleme
                string insertConsultantQuery = "INSERT INTO Consultant (consultantId,email,birthDate, gender, city,firstWeight,targetWeight,height,waist,hip,chest) " +
                                             "VALUES (@ConsultantId,@Email, @BirthDate, @Gender, @City,@FirstWeight,@TargetWeight,@Height,@Waist,@Hip,@Chest )";
                using (SqlCommand command = new SqlCommand(insertConsultantQuery, connection))
                {
                    // Burada uygun parametre değerlerini ekleyin
                    command.Parameters.AddWithValue("@ConsultantId", GetLastUserId(connection).ToString());
                    command.Parameters.AddWithValue("@Email", txtMail.Text);
                    command.Parameters.AddWithValue("@BirthDate", dateBirthDate.Value);
                    command.Parameters.AddWithValue("@Gender", cmbCinsiyet.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@City", txtSehir.Text);
                    command.Parameters.AddWithValue("@FirstWeight", float.Parse(txtMevcutKilo.Text));
                    command.Parameters.AddWithValue("@TargetWeight", float.Parse(txtHedefKilo.Text));
                    command.Parameters.AddWithValue("@Height", int.Parse(txtBoy.Text));
                    command.Parameters.AddWithValue("@Waist", int.Parse(txtBel.Text));
                    command.Parameters.AddWithValue("@Hip", int.Parse(txtKalca.Text));
                    command.Parameters.AddWithValue("@Chest", int.Parse(txtGogus.Text));

                    command.ExecuteNonQuery();
                }

                string insertUpdateKgQuary= "INSERT INTO UpdateTbl (userId,newWeight,newWaist,newHip,newChest,updateTime) " +
                                             "VALUES (@userId,@newWeight,@newWaist,@newHip,@newChest,@updateTime)";

                using (SqlCommand command= new SqlCommand(insertUpdateKgQuary, connection))
                {
                    command.Parameters.AddWithValue("@userId", GetLastUserId(connection).ToString());
                    command.Parameters.AddWithValue("@newWeight", float.Parse(txtMevcutKilo.Text));
                    command.Parameters.AddWithValue("@newWaist", int.Parse(txtBel.Text));
                    command.Parameters.AddWithValue("@newHip", int.Parse(txtKalca.Text));
                    command.Parameters.AddWithValue("@newChest", int.Parse(txtGogus.Text));
                    command.Parameters.AddWithValue("@updateTime", DateTime.Now);

                    command.ExecuteNonQuery();
                }


                MessageBox.Show("Kayıt başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearForm();

        }
        private int GetLastUserId(SqlConnection connection)
        {
            // Users tablosundaki son eklenen kullanıcının Id'sini getirme
            string getLastUserIdQuery = "SELECT MAX(Id) FROM Users";
            using (SqlCommand command = new SqlCommand(getLastUserIdQuery, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }
        private void ClearForm()
        {
            // Tüm TextBox ve ComboBox kontrol elemanlarını temizle
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }

            // Tarih seçici kontrolünü bugünkü tarihe ayarla
            dateBirthDate.Value = DateTime.Today;
        }


    }

}





