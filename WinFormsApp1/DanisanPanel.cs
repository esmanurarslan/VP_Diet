using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsApp1
{
    public partial class DanisanPanel : Form
    {
        public DanisanPanel()
        {
            InitializeComponent();
        }

        

        private void grafikPanel_Paint(object sender, PaintEventArgs e)
        {
            /*Örnek veri seti (kilo ve zaman verileri)
           // DateTime[] dates = { DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), DateTime.Now };
            double[] weights = { 70.5, 71.2, 69.8, 72.0, 70.7, 73.2 };

            // Chart kontrolüne verileri ekleme
            for (int i = 0; i < dates.Length; i++)
            {
                chart1.Series["Weight"].Points.AddXY(dates[i], weights[i]);
            }

            // Eksen başlıkları ve grafiğin başlığı
            chart1.ChartAreas[0].AxisX.Title = "Tarih";
            chart1.ChartAreas[0].AxisY.Title = "Kilo (kg)";
            chart1.Titles.Add("Kilo Zaman Grafiği"); */
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Guncelle frm = new Guncelle();
            frm.Show();
        }
    }
}
