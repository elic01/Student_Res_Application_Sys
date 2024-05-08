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
    public partial class FrmStudentDetails : Form
    {
        public FrmStudentDetails()
        {
            InitializeComponent();
        }
        private void FrmStudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAffairsResSystemDataSet.students' table. You can move, or remove it, as needed.
            //this.studentsTableAdapter.Fill(this.studentAffairsResSystemDataSet.students);

        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentAffairsResSystemDataSet);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWelcomeDash frmWelcomeDash = new FrmWelcomeDash();
            frmWelcomeDash.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentAffairsResSystemDataSet);

        }
    }
}
