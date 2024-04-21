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
using System.Runtime.Remoting.Contexts;

namespace Student_Res_Application_Sys
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\source\repos\Student_Res_Application_Sys\Student_Res_Application_Sys\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30";
        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameAdmin.Text;
            string password = TxtBoxPassAdmin.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM admin WHERE username = @Username AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        FrmMainMenuAdmin mainMenuAdmin = new FrmMainMenuAdmin();
                        mainMenuAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                    

                
            }
        }

        private void ToggleShowPassAdmin_ToggledChanged()
        {
            
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
