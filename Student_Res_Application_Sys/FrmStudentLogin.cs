﻿using System;
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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\Documents\db\New folder\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=False";
        private void BtnLoginStdnt_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameStdnt.Text;
            string password = TxtBoxPassStdnt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM student_users WHERE username = @username AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        FrmWelcomeDash frmWelcomeDash = new FrmWelcomeDash();
                        frmWelcomeDash.Hide();
                        FrmStudentDetails studentDetails = new FrmStudentDetails();
                        studentDetails.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        
        }

        private void LinkLblForgotPassStdnt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("PLEASE CONTACT THE ADMINSTRATOR FOR MORE DETAILS. THANK YOU");
        }
    }
}
