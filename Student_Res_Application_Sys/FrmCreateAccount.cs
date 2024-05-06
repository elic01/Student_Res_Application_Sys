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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentAffairsResSystem.mdf;Integrated Security=True;Connect Timeout=30";

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
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", TxtBoxUsernameCreateAcc.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", TxtBoxPassCreateAcc.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully,  GO TO STUDENT LOGIN!");
                    TxtBoxUsernameCreateAcc.Clear();
                    TxtBoxPassCreateAcc.Clear();

                }
            }
        }
    }
}
