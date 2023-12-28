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
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawLineChart();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-9HENLSU2;Initial Catalog=VP_diet;Integrated Security=True;TrustServerCertificate=True");

        private void DrawLineChart()
        {
            // Chart kontrolü oluşturun
            Chart chart1 = new Chart();
            chart1.Size = new System.Drawing.Size(400, 300);
            chart1.ChartAreas.Add(new ChartArea("ChartArea"));

            // Veri serisi oluşturun
            Series series = new Series("MySeries");
            series.ChartType = SeriesChartType.Line;

            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            series.Points.AddXY(4, 25);

            // Seriyi grafiğe ekleyin
            chart1.Series.Add(series);


            // Chart kontrolünü formunuza ekleyin
            Controls.Add(chart1);
        }
    }
}