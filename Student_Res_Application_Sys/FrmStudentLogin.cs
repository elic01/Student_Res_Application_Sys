using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Res_Application_Sys
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
                   }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\source\repos\Student_Res_Application_Sys\Student_Res_Application_Sys\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30";
        private void BtnLoginStdnt_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameStdnt.Text;
            string password = TxtBoxPassStdnt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM student WHERE username = @Username AND password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        FrmStudentDetails studentDetails = new FrmStudentDetails();
                        studentDetails.Show();
                    }

                    else
                    {
                        // Authentication failed
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        
        }
    }
}
