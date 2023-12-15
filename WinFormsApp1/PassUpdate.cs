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

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
