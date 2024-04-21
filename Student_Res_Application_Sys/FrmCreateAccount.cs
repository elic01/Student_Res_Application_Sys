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
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\source\repos\Student_Res_Application_Sys\Student_Res_Application_Sys\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30";
        private void BtnLoginCreateAcc_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameCreateAcc.Text;
            string password = TxtBoxPassCreateAcc.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM student WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        
                        MessageBox.Show("Username already exists");
                    }
                    else
                    {
                        query = "INSERT INTO student (username, password) VALUES (@Username, @Password)";
                        using (SqlCommand insertCommand = new SqlCommand(query, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Username", username);
                            insertCommand.Parameters.AddWithValue("@Password", password);
                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Account creation Successful");
                            this.Hide();
                            FrmStudentLogin frmStudentLogin = new FrmStudentLogin();
                            frmStudentLogin.Show(); 

                        }
                    }
                }
            }
        }
    }
}
