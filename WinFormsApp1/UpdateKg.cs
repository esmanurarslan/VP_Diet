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
        public int Id;

        
        public Guncelle(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKiloUpdate.Text, out double kilo))
            {
                /*kiloListesi.Add(kilo);
                txtKiloUpdate.Clear();
                MessageBox.Show("Güncelleme Başarılı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
