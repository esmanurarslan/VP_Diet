using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Şevval's database
//Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;Trust Server Certificate=True


namespace WinFormsApp1
{
    public partial class DanisanPanel : Form
    {
        public int Id;



        public DanisanPanel(int id)
        {
            InitializeComponent();
            //this.Id = id;
            LoadConsultantData(this.Id = id);
        }

        /*private void DanisanPanel_Load(object sender, EventArgs e)
        {
            DrawLines();
        }

        private void DrawLines()
        {
            using (Graphics g = this.CreateGraphics())
            {
                 using (Pen p = new Pen(Color.Black, 1))
                 {
                     // Burada label'ın üstündeki ve altındaki çizgileri çizebilirsiniz.
                     // Örneğin, eğer label adı "label9" ise:
                     int label9Top = label9.Top;
                     int label9Bottom = label9.Bottom;

                    g.DrawLine(p, new Point(0, label9Top), new Point(this.Width, label9Top));
                     g.DrawLine(p, new Point(0, label9Bottom), new Point(this.Width, label9Bottom)); 

                 }
                
            }
        }
        */

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void LoadConsultantData(int id)
        {
            using (baglanti) // connectionString'i uygun şekilde değiştirin
            {
                baglanti.Open();

                // İlk SqlCommand için SqlDataReader
                using (SqlCommand komut2 = new SqlCommand("SELECT * FROM Consultant WHERE consultantId = @id", baglanti))
                {
                    komut2.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = komut2.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            string email = dataReader["email"].ToString();
                            lblMail.Text = email;
                            string boy = dataReader["height"].ToString();
                            boyLbl.Text = boy;
                        }
                    }
                }

                // İkinci SqlCommand için SqlDataReader
                using (SqlCommand komut1 = new SqlCommand("SELECT * FROM Users WHERE Id = @id", baglanti))
                {
                    komut1.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader2 = komut1.ExecuteReader())
                    {
                        if (dataReader2.Read())
                        {
                            string kullaniciAdi = dataReader2["userName"].ToString();
                            lblKullaniciAdi.Text = kullaniciAdi;
                            DateTime registerDate = Convert.ToDateTime(dataReader2["registerDate"]);

                            // Gün sayısını hesaplayarak label'a atama yapın
                            TimeSpan difference = DateTime.Now - registerDate;
                            int gunSayisi = (int)difference.TotalDays;

                            lblGun.Text = gunSayisi.ToString();
                        }
                    }
                }
            }

            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UpdateKg frm = new UpdateKg(Id);
            this.Opacity = 0.5;
            frm.FormClosed += (s, args) =>
            {
                // Guncelle formu kapatıldığında ana formun saydamlığını 1.0 olarak ayarla
                this.Opacity = 1.0;
            };
            frm.Show();
        }


        private void btnArama_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = txtArama.Text;
            // buraya girilen kullanıcı adını databaseden çeken ve diyetisyen gönderen kodu yazacağım

        }

        private void DanisanPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnParola_Click(object sender, EventArgs e)
        {
            PassUpdate frm = new PassUpdate(Id);
            this.Opacity = 0.5;
            frm.FormClosed += (s, args) =>
            {
                // Guncelle formu kapatıldığında ana formun saydamlığını 1.0 olarak ayarla
                this.Opacity = 1.0;
            };
            frm.Show();
        }
    }


}