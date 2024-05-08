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
    public partial class FrmMainMenuAdmin : Form
    {
        public FrmMainMenuAdmin()
        {
            InitializeComponent();
        }

        private void BtnStudentDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStudentDetailsAdmin studentdetailsadmin = new FrmStudentDetailsAdmin();
            studentdetailsadmin.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();    
            FrmAccomodationDetailsAdmin accomodationDetailsAdmin = new FrmAccomodationDetailsAdmin();
            accomodationDetailsAdmin.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSettingsAdmin settingsadmin = new FrmSettingsAdmin();
            settingsadmin.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmWelcomeDash frmWelcomeDash = new FrmWelcomeDash();
            frmWelcomeDash.Show();
        }
    }
}
