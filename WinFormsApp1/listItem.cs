using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class listItem : UserControl
    {
        public int Id;

        public listItem(int id)
        {
            InitializeComponent();
            Id = id;
            btnIncele.Click += BtnIncele_Click;

        }
        public event EventHandler<int> InceleClicked;
        private void BtnIncele_Click(object sender, EventArgs e)
        {
            // InceleClicked etkinliğini başlat
            InceleClicked?.Invoke(this, DietitianId);
        }

        #region Properties
        private int dietitianId;
        private string name;
        private string puan;
        public event EventHandler<int> btnInceleClicked;
       

        [Category("Custom Props")]
        public string Name
        {
            get { return name; }
            set { name = value; lblUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string Puan
        {
            get { return puan; }
            set { puan = value; lblPuan.Text = value; }
        }

        [Category("Custom Props")]
        public int DietitianId
        {
            get { return dietitianId; }
            set { dietitianId = value; }
        }


        #endregion

    }
}
