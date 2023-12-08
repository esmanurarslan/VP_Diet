using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            private void button1_Click(object sender, EventArgs e)
            {
                Guncelle frm = new Guncelle();
                frm.Show();
            }


            private void btnArama_Click(object sender, EventArgs e)
            {
                string aramaKelimesi = txtArama.Text;
                // buraya girilen kullanıcı adını databaseden çeken ve diyetisyen gönderen kodu yazacağım

            }


        }

 
}




