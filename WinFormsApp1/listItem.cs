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

        private string _userName;
        private Color _backColor;
        private Image _icon;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listItem_Load(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; lblUsername.Text = value; }
        }


        [Category("Custom Props")]
        public Image MyProperty
        {
            get { return _icon; }
            set { _icon = value; circularPictureBox1.Image = value; }

        }

        [Category("Custom Props")]
        public Color ImageBackColor

        {
            get { return _backColor; }
            set { _backColor = value; panel1.BackColor = value; }

        }


        #endregion 

    }
}
