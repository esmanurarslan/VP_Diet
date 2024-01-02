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
    public partial class DietitianItem : UserControl
    {
        public int Id;
        public DietitianItem(int id)
        {
            InitializeComponent();
            Id = id;
            btnInspect.Click += btnInspect_Click;
        }
        public EventHandler<int> InspectClicked;

        private void btnInspect_Click(object sender, EventArgs e)
        {
            InspectClicked?.Invoke(this, ConsultantId);
        }

        //Properties
        private int consultantId;
        private string userName;
        private string email;
        private string city;
        private Image photo;


        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }



        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public int ConsultantId
        { 
            get { return consultantId; } 
            set { consultantId = value; } 
        }






    }
}
