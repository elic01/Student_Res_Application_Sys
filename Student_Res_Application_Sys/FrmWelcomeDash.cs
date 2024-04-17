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
    public partial class FrmWelcomeDash : Form
    {
        FrmAdminLogin adminLogin;
        FrmStudentLogin studentLogin;
        FrmCreateAccount createAccount;
        public FrmWelcomeDash()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp() {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void FrmWelcomeDash_Load(object sender, EventArgs e)
        {

        }

        private void BtnStudentLogin_Click(object sender, EventArgs e)
        {
            if (studentLogin == null)
            {
                studentLogin = new FrmStudentLogin();
                studentLogin.FormClosed += StudentLogin_FormClosed;
                studentLogin.MdiParent = this;
                studentLogin.Show();
            }
            else
            {
                studentLogin.Activate();
            }
        }

        private void StudentLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentLogin = null;
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            if (adminLogin == null)
            {
                adminLogin = new FrmAdminLogin();
                adminLogin.FormClosed += AdminLogin_FormClosed;
                adminLogin.MdiParent = this;
                adminLogin.Show();
            }
            else
            {
                adminLogin.Activate();
            }
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminLogin = null;  
        }

        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            if (createAccount == null)
            {
                createAccount = new FrmCreateAccount();
                createAccount.FormClosed += CreateAccount_FormClosed;
                createAccount.MdiParent = this;
                createAccount.Show();
            }
            else
            {
                createAccount.Activate();
            }
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
           createAccount = null;    
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Are Now Exiting The System", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}
