﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Res_Application_Sys
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishea\Documents\db\New folder\StudentAffairsResSystem.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=False";
        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameAdmin.Text;
            string password = TxtBoxPassAdmin.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM admin_users WHERE username = @username AND password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        FrmMainMenuAdmin mainMenuAdmin = new FrmMainMenuAdmin();
                        mainMenuAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
