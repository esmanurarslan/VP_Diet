﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Şevval's Database
//Data Source = LAPTOP - 9HENLSU2; Initial Catalog = VP_diet; Integrated Security = True; Encrypt = True; Trust Server Certificate=True


namespace WinFormsApp1
{
    public partial class FormDiyetisyenKayit : Form
    {
        public FormDiyetisyenKayit()
        {
            InitializeComponent();
        }
       // SqlConnection baglanti = new SqlConnection(@"Data Source = LAPTOP - 9HENLSU2; Initial Catalog = VP_diet; Integrated Security = True; Encrypt = True; Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();

        }



        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click_1(object sender, EventArgs e)
        {

        }

        private void FormDiyetisyenKayit_Load(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
           
            // Kullanıcı adı ve şifre kontrolü
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
                    command.Parameters.AddWithValue("@UserName", txtUser.Text);
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
                    command.Parameters.AddWithValue("@Email", txtEposta.Text);
                    int existingEmailCount = (int)command.ExecuteScalar();

                    if (existingEmailCount > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kullanılmış. Lütfen başka bir e-posta adresi kullanın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Users tablosuna kullanıcı ekleme
                string insertUserQuery = "INSERT INTO Users (userName, password, userType, registerDate,email) VALUES (@UserName, @Password, 2, @RegisterDate,@Email)";
                using (SqlCommand command = new SqlCommand(insertUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", txtUser.Text);
                    command.Parameters.AddWithValue("@Password", txtParola.Text);
                    command.Parameters.AddWithValue("@RegisterDate", DateTime.Now);
                    command.Parameters.AddWithValue("@Email", txtEposta.Text);
                    command.ExecuteNonQuery();
                }

                // Dietitian tablosuna diyetisyen ekleme
                string insertDietitianQuery = "INSERT INTO Dietitian (dietitianId, nameSurname, email, birthDate, gender, city, education, specialization, university) " +
                                             "VALUES (@DietitianId, @NameSurname, @Email, @BirthDate, @Gender, @City, @Education, @Specialization, @University)";
                using (SqlCommand command = new SqlCommand(insertDietitianQuery, connection))
                {
                    // Burada uygun parametre değerlerini ekleyin
                    command.Parameters.AddWithValue("@DietitianId", GetLastUserId(connection).ToString());
                    command.Parameters.AddWithValue("@NameSurname", txtAd.Text);
                    command.Parameters.AddWithValue("@Email", txtEposta.Text);
                    command.Parameters.AddWithValue("@BirthDate", dateBirthDate.Value);
                    command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@City", txtCity.Text);
                    command.Parameters.AddWithValue("@Education", cmbEgitim.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Specialization", txtUzmanlik.Text);
                    command.Parameters.AddWithValue("@University", txtUniversite.Text);
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

