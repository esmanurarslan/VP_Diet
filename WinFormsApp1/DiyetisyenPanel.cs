using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class DiyetisyenPanel : Form
    {

        public DiyetisyenPanel()
        {
            InitializeComponent();

        }
        
        SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=VP_diet;Integrated Security=True");

        private void LoadDietitanData(int id)
        {
            using(connection)
                try
                {
                    connection.Open();

                    string Command = "SELECT * FROM";

                    using (SqlCommand cmdID = new SqlCommand(Command + "Users WHERE Id = @id ", connection))
                    {
                        cmdID.Parameters.AddWithValue("id", id);

                        using(SqlDataReader reader1 = cmdID.ExecuteReader())
                        {
                            if (reader1.Read())
                            {
                                string userName = reader1["userName"].ToString();
                                DateTime dateLog = DateTime.Now;
                                Console.WriteLine($"User Name : {userName}, Time : {dateLog}");
                            }
                        }
                    }

                    using (SqlCommand cmdNameSurname = new SqlCommand(Command + "Dietitan WHERE dietitanId = @id ",connection))
                    {
                        cmdNameSurname.Parameters.AddWithValue("@id", id);

                        using(SqlDataReader reader2 = cmdNameSurname.ExecuteReader())
                        {
                            if(reader2.Read())
                            {
                                string nameSurname = reader2["nameSurname"].ToString();
                                string email = reader2["email"].ToString();
                                string university = reader2["university"].ToString();
                                string city = reader2["city"].ToString();

                                lblDietUserName.Text = nameSurname;
                                lblDietMail.Text = email;
                                lblDietSchool.Text = university; 
                                lblCity.Text = city;
                            } 
                        }

                        using (SqlCommand cmdPartnerNumber = new SqlCommand(Command + "Partner WHERE dietitan = @id ", connection))
                        {

                        }
                    }

                }catch(Exception ex) { }

        }

        

    }
}
