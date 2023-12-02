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
    public partial class FormDiyetisyenKayit : Form
    {
        public FormDiyetisyenKayit()
        {
            InitializeComponent();
        }

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

        private void txtBSertifikalar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtBSertifikalar.Text = openFileDialog.FileName;
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
    }
}
