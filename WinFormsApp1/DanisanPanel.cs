﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Şevval's database
//Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;Encrypt=True;Trust Server Certificate=True
//esma db   Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True


namespace WinFormsApp1
{
    public partial class DanisanPanel : Form
    {
        public int Id;
        private Panel myPanel;


        public DanisanPanel(int id)
        {
            InitializeComponent();
            //this.Id = id;
            LoadConsultantData(this.Id = id);
            // UpdateCompleted olayına abone ol
            UpdateKg updateKgForm = new UpdateKg(Id);
            updateKgForm.UpdateCompleted += UpdateKgForm_UpdateCompleted;
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

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");
        private void UpdateKgForm_UpdateCompleted(object sender, EventArgs e)
        {
            // Güncelleme tamamlandığında yapılacak işlemler
            LoadConsultantData(Id); // veya başka güncelleme işlemleri
        }
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
                            int boy1 = Convert.ToInt32(dataReader["height"]);
                            string target = dataReader["targetWeight"].ToString();
                            lblTarget.Text = target;


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
                            lblUser.Text = kullaniciAdi;
                            DateTime registerDate = Convert.ToDateTime(dataReader2["registerDate"]);

                            // Gün sayısını hesaplayarak label'a atama yapın
                            TimeSpan difference = DateTime.Now - registerDate;
                            int gunSayisi = (int)difference.TotalDays;

                            lblGun.Text = gunSayisi.ToString();
                        }
                    }
                }


                using (SqlCommand komut3 = new SqlCommand("SELECT TOP 1 * FROM UpdateTbl WHERE userId = @id ORDER BY updateTime DESC", baglanti))
                {
                    komut3.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader3 = komut3.ExecuteReader())
                    {
                        if (dataReader3.Read())
                        {
                            string newWeight = dataReader3["newWeight"].ToString();
                            kiloLbl.Text = newWeight;

                            string newWaist = dataReader3["newWaist"].ToString();
                            belLbl.Text = newWaist;

                            string newHip = dataReader3["newHip"].ToString();
                            kalcaLbl.Text = newHip;

                            string newChest = dataReader3["newChest"].ToString();
                            gogusLbl.Text = newChest;

                            double kilo = Convert.ToDouble(dataReader3["newWeight"]);
                            //double boy1 = Convert.ToDouble(dataReader3["height"]);
                            //double vki = kilo / ((boy1 / 100) * (boy1 / 100)); // Formül: VKI = kilo / (boy * boy)

                            //lblVki.Text = vki.ToString("F2");


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
                //this.Update();
                this.Opacity = 1.0;

            };
            frm.Show();

        }


        private void btnArama_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = txtArama.Text;

            SearchDietitian(aramaKelimesi);
            // buraya girilen kullanıcı adını databaseden çeken ve diyetisyen gönderen kodu yazacağım

        }

        private void dietitianPanel()
        {
            Panel myPanel = new Panel();

            myPanel.Location = new System.Drawing.Point(10,60);
            myPanel.Size = new System.Drawing.Size(241,84);
            myPanel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);


            Button myButton = new Button();
            myButton.Text = "İletişime Geç!";
            myButton.Location = new System.Drawing.Point(180,60);


            myPanel.Controls.Add(myButton);
            myButton.Click += MyButton_Click;

            this.Controls.Add(myPanel);

        }

        //İletişime Geç butona click edildiğinde olacaklar
        private void MyButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchDietitian(string nameSurname)
        {
            // Veritabanı sorgusu
            string query = "SELECT * FROM Dietitians WHERE dietitianId =@id";

            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@nameSurname", nameSurname);

            baglanti.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                myPanel.Visible = true;
                
                
            }
            else
            {

                MessageBox.Show("Diyetisyen bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                   
            }

            reader.Close();
            baglanti.Close();
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanisanPanel form = new DanisanPanel(Id);
            form.Show();
            this.Close();
        }
    }


}