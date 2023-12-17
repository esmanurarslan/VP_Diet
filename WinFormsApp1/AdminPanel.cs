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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadUserStatistics();
            LoadDietStatistics();
            LoadConsultantStatistics();
        }

        private void LoadUserStatistics()
        {
            try
            {
                baglanti.Open();

                // Toplam kullanıcı sayısı
                SqlCommand cmdTotalUser = new SqlCommand("SELECT COUNT(*) FROM Users where userType in(2,3)", baglanti);
                int totalUser = Convert.ToInt32(cmdTotalUser.ExecuteScalar());
                lblTotalUser.Text = totalUser.ToString();

                // Bugün kayıt olan kullanıcı sayısı
                SqlCommand cmdUserToday = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int userToday = Convert.ToInt32(cmdUserToday.ExecuteScalar());
                lblUserToday.Text = userToday.ToString();

                // Son bir haftada kayıt olan kullanıcı sayısı
                SqlCommand cmdUserWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int userWeek = Convert.ToInt32(cmdUserWeek.ExecuteScalar());
                lblUserWeek.Text = userWeek.ToString();

                // Son bir ayda kayıt olan kullanıcı sayısı
                SqlCommand cmdUserMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE  userType in(2,3) and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int userMonth = Convert.ToInt32(cmdUserMonth.ExecuteScalar());
                lblUserMonth.Text = userMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LoadDietStatistics()
        {
            try
            {
                baglanti.Open();

                // Diyet toplam sayısı
                SqlCommand cmdDietTotal = new SqlCommand("SELECT COUNT(*) FROM Users Where userType=2", baglanti);
                int dietTotal = Convert.ToInt32(cmdDietTotal.ExecuteScalar());
                lblDietTotal.Text = dietTotal.ToString();

                // Bugünkü diyet sayısı
                SqlCommand cmdDietDay = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int dietDay = Convert.ToInt32(cmdDietDay.ExecuteScalar());
                lblDietDay.Text = dietDay.ToString();

                // Son bir haftada eklenen diyet sayısı
                SqlCommand cmdDietWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int dietWeek = Convert.ToInt32(cmdDietWeek.ExecuteScalar());
                lblDietWeek.Text = dietWeek.ToString();

                // Son bir ayda eklenen diyet sayısı
                SqlCommand cmdDietMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=2 and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int dietMonth = Convert.ToInt32(cmdDietMonth.ExecuteScalar());
                lblDietMonth.Text = dietMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LoadConsultantStatistics()
        {
            try
            {
                baglanti.Open();

                // Danışman toplam sayısı
                SqlCommand cmdConTotal = new SqlCommand("SELECT COUNT(*) FROM Users Where userType=3", baglanti);
                int conTotal = Convert.ToInt32(cmdConTotal.ExecuteScalar());
                lblConTotal.Text = conTotal.ToString();

                // Bugünkü danışman sayısı
                SqlCommand cmdConDay = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and CONVERT(date, registerDate) = CONVERT(date, GETDATE())", baglanti);
                int conDay = Convert.ToInt32(cmdConDay.ExecuteScalar());
                lblConDay.Text = conDay.ToString();

                // Son bir haftada eklenen danışman sayısı
                SqlCommand cmdConWeek = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and registerDate >= DATEADD(day, -7, GETDATE())", baglanti);
                int conWeek = Convert.ToInt32(cmdConWeek.ExecuteScalar());
                lblConWeek.Text = conWeek.ToString();

                // Son bir ayda eklenen danışman sayısı
                SqlCommand cmdConMonth = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userType=3 and registerDate >= DATEADD(month, -1, GETDATE())", baglanti);
                int conMonth = Convert.ToInt32(cmdConMonth.ExecuteScalar());
                lblConMonth.Text = conMonth.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


    }
}
