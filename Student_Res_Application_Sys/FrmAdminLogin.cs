using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Res_Application_Sys
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source= C:\Users\ishea\source\repos\Student_Res_Application_Sys\Student_Res_Application_Sys\StudentAffairsResSystem.mdf";
        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUsernameAdmin.Text;
            string password = TxtBoxPassAdmin.Text;
        }

        private void ToggleShowPassAdmin_ToggledChanged()
        {
            
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
