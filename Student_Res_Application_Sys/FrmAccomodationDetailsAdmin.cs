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
    public partial class FrmAccomodationDetailsAdmin : Form
    {
        public FrmAccomodationDetailsAdmin()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentAffairsResSystemDataSet);

        }

        private void FrmAccomodationDetailsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAffairsResSystemDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentAffairsResSystemDataSet.students);

        }
    }
}
