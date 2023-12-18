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
        public listItem()
        {
            InitializeComponent();
        }


        #region Properties

        private string name;
        private string puan;
       

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

        #endregion

    }
}
