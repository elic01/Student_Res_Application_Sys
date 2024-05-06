using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\Documents\db\New folder\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=False";

        private void BtnLoginCreateAcc_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameCreateAcc.Text;
            string password = TxtBoxPassCreateAcc.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter a username and password");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

               
                    string insertQuery = @"INSERT INTO student_users (username, password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account created successfully, GO TO STUDENT LOGIN!");
                        TxtBoxUsernameCreateAcc.Clear();
                        TxtBoxPassCreateAcc.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account. Please contact the administrator.");
                    }
                }
            }
        }
        
    }
}
