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
    public partial class FrmSettingsAdmin : Form
    {
        public FrmSettingsAdmin()
        {
            InitializeComponent();
        }

        private void student_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentAffairsResSystemDataSet);

        }

        private void FrmSettingsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAffairsResSystemDataSet.admin_users' table. You can move, or remove it, as needed.
            this.admin_usersTableAdapter.Fill(this.studentAffairsResSystemDataSet.admin_users);
            // TODO: This line of code loads data into the 'studentAffairsResSystemDataSet.student_users' table. You can move, or remove it, as needed.
            this.student_usersTableAdapter.Fill(this.studentAffairsResSystemDataSet.student_users);

        }
    }
}
