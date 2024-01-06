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
    public partial class PassUpdate : Form
    {
        public int Id;
        public PassUpdate(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldP.Text;
            string newPassword = txtNewP.Text;
            string newPasswordRepeat = txtNewPTekrar.Text;

            // Eski şifre, kullanıcının mevcut şifresini Users tablosundan kontrol et
            string checkOldPasswordQuery = "SELECT COUNT(*) FROM Users WHERE Id = @id AND Password = @password";
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();
                using (SqlCommand checkOldPasswordCommand = new SqlCommand(checkOldPasswordQuery, connection))
                {
                    checkOldPasswordCommand.Parameters.AddWithValue("@id", Id);
                    checkOldPasswordCommand.Parameters.AddWithValue("@password", oldPassword);

                    int count = (int)checkOldPasswordCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Eski şifre hatalı. Lütfen doğru bir şekilde giriniz.");
                        return;
                    }
                }
            }

            // Yeni şifre ve tekrarını kontrol et
            if (newPassword != newPasswordRepeat)
            {
                MessageBox.Show("Yeni şifre ve tekrarı uyuşmuyor. Lütfen tekrar kontrol ediniz.");
                return;
            }

            // Yeni şifreyi Users tablosunda güncelle
            string updatePasswordQuery = "UPDATE Users SET Password = @newPassword WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();
                using (SqlCommand updatePasswordCommand = new SqlCommand(updatePasswordQuery, connection))
                {
                    updatePasswordCommand.Parameters.AddWithValue("@newPassword", newPassword);
                    updatePasswordCommand.Parameters.AddWithValue("@id", Id);

                    updatePasswordCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Şifre güncellendi.");
            this.Close();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
