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
    public partial class ConsultantItem : UserControl
    {
        public int Id;
        public ConsultantItem(int id)
        {
            InitializeComponent();
            Id = id;
            btnIncele.Click += btnIncele_Click;

        }
        public event EventHandler<int> InceleClicked;
        private void btnIncele_Click(object sender, EventArgs e)
        {
            InceleClicked?.Invoke(this, ConsultantId);
        }

        private void ConsultantItem_Load(object sender, EventArgs e)
        {

        }
        #region Properties
        private string username;
        private string gun;
        private int consultantId;


        [Category("Custom Props")]
        public string Username
        {
            get { return username; }
            set { username = value; lblUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string Gun
        {
            get { return gun; }
            set { gun = value; lblGun.Text = value; }
        }


        [Category("Custom Props")]
        public int ConsultantId
        {
            get { return consultantId; }
            set { consultantId = value; }
        }
        #endregion

    }
}
