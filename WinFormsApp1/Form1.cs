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
    public partial class Guncelle : Form
    {

        private List<double> kiloListesi = new List<double>();
        public Guncelle()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double kilo))
            {
                kiloListesi.Add(kilo);
                textBox1.Clear();
                MessageBox.Show("Güncelleme Başarılı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Geçerli bir kilo değeri giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
