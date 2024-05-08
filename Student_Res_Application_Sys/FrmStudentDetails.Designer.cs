namespace Student_Res_Application_Sys
{
    partial class FrmStudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label student_idLabel;
            System.Windows.Forms.Label student_nameLabel;
            System.Windows.Forms.Label student_surnameLabel;
            System.Windows.Forms.Label student_emailLabel;
            System.Windows.Forms.Label national_id_numberLabel;
            System.Windows.Forms.Label level_partLabel;
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label special_circumstancesLabel;
            System.Windows.Forms.Label allergiesLabel;
            System.Windows.Forms.Label guardian_nameLabel;
            System.Windows.Forms.Label guardian_idLabel;
            System.Windows.Forms.Label guardian_phone_numberLabel;
            System.Windows.Forms.Label relationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentDetails));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentAffairsResSystemDataSet = new Student_Res_Application_Sys.StudentAffairsResSystemDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.studentsTableAdapter();
            this.tableAdapterManager = new Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_idTextBox = new System.Windows.Forms.TextBox();
            this.student_nameTextBox = new System.Windows.Forms.TextBox();
            this.student_surnameTextBox = new System.Windows.Forms.TextBox();
            this.student_emailTextBox = new System.Windows.Forms.TextBox();
            this.national_id_numberTextBox = new System.Windows.Forms.TextBox();
            this.level_partTextBox = new System.Windows.Forms.TextBox();
            this.date_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.special_circumstancesTextBox = new System.Windows.Forms.TextBox();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.guardian_nameTextBox = new System.Windows.Forms.TextBox();
            this.guardian_idTextBox = new System.Windows.Forms.TextBox();
            this.guardian_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.relationTextBox = new System.Windows.Forms.TextBox();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            student_idLabel = new System.Windows.Forms.Label();
            student_nameLabel = new System.Windows.Forms.Label();
            student_surnameLabel = new System.Windows.Forms.Label();
            student_emailLabel = new System.Windows.Forms.Label();
            national_id_numberLabel = new System.Windows.Forms.Label();
            level_partLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            special_circumstancesLabel = new System.Windows.Forms.Label();
            allergiesLabel = new System.Windows.Forms.Label();
            guardian_nameLabel = new System.Windows.Forms.Label();
            guardian_idLabel = new System.Windows.Forms.Label();
            guardian_phone_numberLabel = new System.Windows.Forms.Label();
            relationLabel = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAffairsResSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.Location = new System.Drawing.Point(70, 189);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(110, 28);
            student_idLabel.TabIndex = 33;
            student_idLabel.Text = "student id:";
            // 
            // student_nameLabel
            // 
            student_nameLabel.AutoSize = true;
            student_nameLabel.Location = new System.Drawing.Point(70, 229);
            student_nameLabel.Name = "student_nameLabel";
            student_nameLabel.Size = new System.Drawing.Size(144, 28);
            student_nameLabel.TabIndex = 35;
            student_nameLabel.Text = "student name:";
            // 
            // student_surnameLabel
            // 
            student_surnameLabel.AutoSize = true;
            student_surnameLabel.Location = new System.Drawing.Point(70, 269);
            student_surnameLabel.Name = "student_surnameLabel";
            student_surnameLabel.Size = new System.Drawing.Size(172, 28);
            student_surnameLabel.TabIndex = 37;
            student_surnameLabel.Text = "student surname:";
            // 
            // student_emailLabel
            // 
            student_emailLabel.AutoSize = true;
            student_emailLabel.Location = new System.Drawing.Point(70, 309);
            student_emailLabel.Name = "student_emailLabel";
            student_emailLabel.Size = new System.Drawing.Size(142, 28);
            student_emailLabel.TabIndex = 39;
            student_emailLabel.Text = "student email:";
            // 
            // national_id_numberLabel
            // 
            national_id_numberLabel.AutoSize = true;
            national_id_numberLabel.Location = new System.Drawing.Point(70, 349);
            national_id_numberLabel.Name = "national_id_numberLabel";
            national_id_numberLabel.Size = new System.Drawing.Size(192, 28);
            national_id_numberLabel.TabIndex = 41;
            national_id_numberLabel.Text = "national id number:";
            // 
            // level_partLabel
            // 
            level_partLabel.AutoSize = true;
            level_partLabel.Location = new System.Drawing.Point(70, 389);
            level_partLabel.Name = "level_partLabel";
            level_partLabel.Size = new System.Drawing.Size(102, 28);
            level_partLabel.TabIndex = 43;
            level_partLabel.Text = "level part:";
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Location = new System.Drawing.Point(70, 430);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(132, 28);
            date_of_birthLabel.TabIndex = 45;
            date_of_birthLabel.Text = "date of birth:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(70, 469);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(155, 28);
            phone_numberLabel.TabIndex = 47;
            phone_numberLabel.Text = "phone number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(610, 186);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(87, 28);
            addressLabel.TabIndex = 49;
            addressLabel.Text = "address:";
            // 
            // special_circumstancesLabel
            // 
            special_circumstancesLabel.AutoSize = true;
            special_circumstancesLabel.Location = new System.Drawing.Point(605, 226);
            special_circumstancesLabel.Name = "special_circumstancesLabel";
            special_circumstancesLabel.Size = new System.Drawing.Size(211, 28);
            special_circumstancesLabel.TabIndex = 51;
            special_circumstancesLabel.Text = "special circumstances:";
            // 
            // allergiesLabel
            // 
            allergiesLabel.AutoSize = true;
            allergiesLabel.Location = new System.Drawing.Point(605, 266);
            allergiesLabel.Name = "allergiesLabel";
            allergiesLabel.Size = new System.Drawing.Size(92, 28);
            allergiesLabel.TabIndex = 53;
            allergiesLabel.Text = "allergies:";
            // 
            // guardian_nameLabel
            // 
            guardian_nameLabel.AutoSize = true;
            guardian_nameLabel.Location = new System.Drawing.Point(605, 306);
            guardian_nameLabel.Name = "guardian_nameLabel";
            guardian_nameLabel.Size = new System.Drawing.Size(154, 28);
            guardian_nameLabel.TabIndex = 55;
            guardian_nameLabel.Text = "guardian name:";
            // 
            // guardian_idLabel
            // 
            guardian_idLabel.AutoSize = true;
            guardian_idLabel.Location = new System.Drawing.Point(605, 346);
            guardian_idLabel.Name = "guardian_idLabel";
            guardian_idLabel.Size = new System.Drawing.Size(120, 28);
            guardian_idLabel.TabIndex = 57;
            guardian_idLabel.Text = "guardian id:";
            // 
            // guardian_phone_numberLabel
            // 
            guardian_phone_numberLabel.AutoSize = true;
            guardian_phone_numberLabel.Location = new System.Drawing.Point(605, 386);
            guardian_phone_numberLabel.Name = "guardian_phone_numberLabel";
            guardian_phone_numberLabel.Size = new System.Drawing.Size(241, 28);
            guardian_phone_numberLabel.TabIndex = 59;
            guardian_phone_numberLabel.Text = "guardian phone number:";
            // 
            // relationLabel
            // 
            relationLabel.AutoSize = true;
            relationLabel.Location = new System.Drawing.Point(605, 426);
            relationLabel.Name = "relationLabel";
            relationLabel.Size = new System.Drawing.Size(86, 28);
            relationLabel.TabIndex = 61;
            relationLabel.Text = "relation:";
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.nightControlBox1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1064, 41);
            this.PanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Res_Application_Sys.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(925, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Enter Details and Save";
            // 
            // studentAffairsResSystemDataSet
            // 
            this.studentAffairsResSystemDataSet.DataSetName = "StudentAffairsResSystemDataSet";
            this.studentAffairsResSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.studentAffairsResSystemDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_usersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.student_usersTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 41);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(1064, 27);
            this.studentsBindingNavigator.TabIndex = 33;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // student_idTextBox
            // 
            this.student_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_id", true));
            this.student_idTextBox.Location = new System.Drawing.Point(273, 186);
            this.student_idTextBox.Name = "student_idTextBox";
            this.student_idTextBox.Size = new System.Drawing.Size(264, 34);
            this.student_idTextBox.TabIndex = 34;
            // 
            // student_nameTextBox
            // 
            this.student_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_name", true));
            this.student_nameTextBox.Location = new System.Drawing.Point(273, 226);
            this.student_nameTextBox.Name = "student_nameTextBox";
            this.student_nameTextBox.Size = new System.Drawing.Size(264, 34);
            this.student_nameTextBox.TabIndex = 36;
            // 
            // student_surnameTextBox
            // 
            this.student_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_surname", true));
            this.student_surnameTextBox.Location = new System.Drawing.Point(273, 266);
            this.student_surnameTextBox.Name = "student_surnameTextBox";
            this.student_surnameTextBox.Size = new System.Drawing.Size(264, 34);
            this.student_surnameTextBox.TabIndex = 38;
            // 
            // student_emailTextBox
            // 
            this.student_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_email", true));
            this.student_emailTextBox.Location = new System.Drawing.Point(273, 306);
            this.student_emailTextBox.Name = "student_emailTextBox";
            this.student_emailTextBox.Size = new System.Drawing.Size(264, 34);
            this.student_emailTextBox.TabIndex = 40;
            // 
            // national_id_numberTextBox
            // 
            this.national_id_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "national_id_number", true));
            this.national_id_numberTextBox.Location = new System.Drawing.Point(273, 346);
            this.national_id_numberTextBox.Name = "national_id_numberTextBox";
            this.national_id_numberTextBox.Size = new System.Drawing.Size(264, 34);
            this.national_id_numberTextBox.TabIndex = 42;
            // 
            // level_partTextBox
            // 
            this.level_partTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "level_part", true));
            this.level_partTextBox.Location = new System.Drawing.Point(273, 386);
            this.level_partTextBox.Name = "level_partTextBox";
            this.level_partTextBox.Size = new System.Drawing.Size(264, 34);
            this.level_partTextBox.TabIndex = 44;
            // 
            // date_of_birthDateTimePicker
            // 
            this.date_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "date_of_birth", true));
            this.date_of_birthDateTimePicker.Location = new System.Drawing.Point(273, 426);
            this.date_of_birthDateTimePicker.Name = "date_of_birthDateTimePicker";
            this.date_of_birthDateTimePicker.Size = new System.Drawing.Size(264, 34);
            this.date_of_birthDateTimePicker.TabIndex = 46;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(273, 466);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(264, 34);
            this.phone_numberTextBox.TabIndex = 48;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(852, 183);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 34);
            this.addressTextBox.TabIndex = 50;
            // 
            // special_circumstancesTextBox
            // 
            this.special_circumstancesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "special_circumstances", true));
            this.special_circumstancesTextBox.Location = new System.Drawing.Point(852, 223);
            this.special_circumstancesTextBox.Name = "special_circumstancesTextBox";
            this.special_circumstancesTextBox.Size = new System.Drawing.Size(200, 34);
            this.special_circumstancesTextBox.TabIndex = 52;
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "allergies", true));
            this.allergiesTextBox.Location = new System.Drawing.Point(852, 263);
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(200, 34);
            this.allergiesTextBox.TabIndex = 54;
            // 
            // guardian_nameTextBox
            // 
            this.guardian_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "guardian_name", true));
            this.guardian_nameTextBox.Location = new System.Drawing.Point(852, 303);
            this.guardian_nameTextBox.Name = "guardian_nameTextBox";
            this.guardian_nameTextBox.Size = new System.Drawing.Size(200, 34);
            this.guardian_nameTextBox.TabIndex = 56;
            // 
            // guardian_idTextBox
            // 
            this.guardian_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "guardian_id", true));
            this.guardian_idTextBox.Location = new System.Drawing.Point(852, 343);
            this.guardian_idTextBox.Name = "guardian_idTextBox";
            this.guardian_idTextBox.Size = new System.Drawing.Size(200, 34);
            this.guardian_idTextBox.TabIndex = 58;
            // 
            // guardian_phone_numberTextBox
            // 
            this.guardian_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "guardian_phone_number", true));
            this.guardian_phone_numberTextBox.Location = new System.Drawing.Point(852, 383);
            this.guardian_phone_numberTextBox.Name = "guardian_phone_numberTextBox";
            this.guardian_phone_numberTextBox.Size = new System.Drawing.Size(200, 34);
            this.guardian_phone_numberTextBox.TabIndex = 60;
            // 
            // relationTextBox
            // 
            this.relationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "relation", true));
            this.relationTextBox.Location = new System.Drawing.Point(852, 423);
            this.relationTextBox.Name = "relationTextBox";
            this.relationTextBox.Size = new System.Drawing.Size(200, 34);
            this.relationTextBox.TabIndex = 62;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::Student_Res_Application_Sys.Properties.Resources.save_512;
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(347, 535);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(86, 36);
            this.materialButton3.TabIndex = 64;
            this.materialButton3.Text = "save";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Student_Res_Application_Sys.Properties.Resources.logout_512;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(925, 544);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(106, 36);
            this.materialButton1.TabIndex = 63;
            this.materialButton1.Text = "Logout";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FrmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 595);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(student_idLabel);
            this.Controls.Add(this.student_idTextBox);
            this.Controls.Add(student_nameLabel);
            this.Controls.Add(this.student_nameTextBox);
            this.Controls.Add(student_surnameLabel);
            this.Controls.Add(this.student_surnameTextBox);
            this.Controls.Add(student_emailLabel);
            this.Controls.Add(this.student_emailTextBox);
            this.Controls.Add(national_id_numberLabel);
            this.Controls.Add(this.national_id_numberTextBox);
            this.Controls.Add(level_partLabel);
            this.Controls.Add(this.level_partTextBox);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(this.date_of_birthDateTimePicker);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(special_circumstancesLabel);
            this.Controls.Add(this.special_circumstancesTextBox);
            this.Controls.Add(allergiesLabel);
            this.Controls.Add(this.allergiesTextBox);
            this.Controls.Add(guardian_nameLabel);
            this.Controls.Add(this.guardian_nameTextBox);
            this.Controls.Add(guardian_idLabel);
            this.Controls.Add(this.guardian_idTextBox);
            this.Controls.Add(guardian_phone_numberLabel);
            this.Controls.Add(this.guardian_phone_numberTextBox);
            this.Controls.Add(relationLabel);
            this.Controls.Add(this.relationTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentDetails";
            this.Load += new System.EventHandler(this.FrmStudentDetails_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAffairsResSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private StudentAffairsResSystemDataSet studentAffairsResSystemDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentAffairsResSystemDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_idTextBox;
        private System.Windows.Forms.TextBox student_nameTextBox;
        private System.Windows.Forms.TextBox student_surnameTextBox;
        private System.Windows.Forms.TextBox student_emailTextBox;
        private System.Windows.Forms.TextBox national_id_numberTextBox;
        private System.Windows.Forms.TextBox level_partTextBox;
        private System.Windows.Forms.DateTimePicker date_of_birthDateTimePicker;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox special_circumstancesTextBox;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.TextBox guardian_nameTextBox;
        private System.Windows.Forms.TextBox guardian_idTextBox;
        private System.Windows.Forms.TextBox guardian_phone_numberTextBox;
        private System.Windows.Forms.TextBox relationTextBox;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
    }
}