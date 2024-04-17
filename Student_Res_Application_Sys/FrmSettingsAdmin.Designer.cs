namespace Student_Res_Application_Sys
{
    partial class FrmSettingsAdmin
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usernameLabel1;
            System.Windows.Forms.Label passwordLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettingsAdmin));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.studentAffairsResSystemDataSet = new Student_Res_Application_Sys.StudentAffairsResSystemDataSet();
            this.student_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_usersTableAdapter = new Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.student_usersTableAdapter();
            this.tableAdapterManager = new Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager();
            this.admin_usersTableAdapter = new Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.admin_usersTableAdapter();
            this.student_usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.student_usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel1 = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAffairsResSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersBindingNavigator)).BeginInit();
            this.student_usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(12, 230);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(70, 16);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 258);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(69, 16);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // usernameLabel1
            // 
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new System.Drawing.Point(605, 230);
            usernameLabel1.Name = "usernameLabel1";
            usernameLabel1.Size = new System.Drawing.Size(70, 16);
            usernameLabel1.TabIndex = 9;
            usernameLabel1.Text = "username:";
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new System.Drawing.Point(605, 258);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(69, 16);
            passwordLabel1.TabIndex = 11;
            passwordLabel1.Text = "password:";
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.nightControlBox1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1144, 35);
            this.PanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Res_Application_Sys.Properties.Resources.settings_sliders;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
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
            this.nightControlBox1.Location = new System.Drawing.Point(1005, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // studentAffairsResSystemDataSet
            // 
            this.studentAffairsResSystemDataSet.DataSetName = "StudentAffairsResSystemDataSet";
            this.studentAffairsResSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_usersBindingSource
            // 
            this.student_usersBindingSource.DataMember = "student_users";
            this.student_usersBindingSource.DataSource = this.studentAffairsResSystemDataSet;
            // 
            // student_usersTableAdapter
            // 
            this.student_usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_usersTableAdapter = this.admin_usersTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.student_usersTableAdapter = this.student_usersTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_Res_Application_Sys.StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // admin_usersTableAdapter
            // 
            this.admin_usersTableAdapter.ClearBeforeFill = true;
            // 
            // student_usersBindingNavigator
            // 
            this.student_usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.student_usersBindingNavigator.BindingSource = this.student_usersBindingSource;
            this.student_usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.student_usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.student_usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.student_usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.student_usersBindingNavigatorSaveItem});
            this.student_usersBindingNavigator.Location = new System.Drawing.Point(0, 35);
            this.student_usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.student_usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.student_usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.student_usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.student_usersBindingNavigator.Name = "student_usersBindingNavigator";
            this.student_usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.student_usersBindingNavigator.Size = new System.Drawing.Size(1144, 31);
            this.student_usersBindingNavigator.TabIndex = 1;
            this.student_usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // student_usersBindingNavigatorSaveItem
            // 
            this.student_usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.student_usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("student_usersBindingNavigatorSaveItem.Image")));
            this.student_usersBindingNavigatorSaveItem.Name = "student_usersBindingNavigatorSaveItem";
            this.student_usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.student_usersBindingNavigatorSaveItem.Text = "Save Data";
            this.student_usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.student_usersBindingNavigatorSaveItem_Click);
            // 
            // student_usersDataGridView
            // 
            this.student_usersDataGridView.AutoGenerateColumns = false;
            this.student_usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.student_usersDataGridView.DataSource = this.student_usersBindingSource;
            this.student_usersDataGridView.Location = new System.Drawing.Point(286, 161);
            this.student_usersDataGridView.Name = "student_usersDataGridView";
            this.student_usersDataGridView.RowHeadersWidth = 51;
            this.student_usersDataGridView.RowTemplate.Height = 24;
            this.student_usersDataGridView.Size = new System.Drawing.Size(300, 242);
            this.student_usersDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_usersBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(103, 227);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(159, 22);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(103, 255);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(159, 22);
            this.passwordTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Settings";
            // 
            // admin_usersBindingSource
            // 
            this.admin_usersBindingSource.DataMember = "admin_users";
            this.admin_usersBindingSource.DataSource = this.studentAffairsResSystemDataSet;
            // 
            // admin_usersDataGridView
            // 
            this.admin_usersDataGridView.AutoGenerateColumns = false;
            this.admin_usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.admin_usersDataGridView.DataSource = this.admin_usersBindingSource;
            this.admin_usersDataGridView.Location = new System.Drawing.Point(836, 161);
            this.admin_usersDataGridView.Name = "admin_usersDataGridView";
            this.admin_usersDataGridView.RowHeadersWidth = 51;
            this.admin_usersDataGridView.RowTemplate.Height = 24;
            this.admin_usersDataGridView.Size = new System.Drawing.Size(300, 242);
            this.admin_usersDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn3.HeaderText = "username";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn4.HeaderText = "password";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_usersBindingSource, "username", true));
            this.usernameTextBox1.Location = new System.Drawing.Point(681, 230);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(149, 22);
            this.usernameTextBox1.TabIndex = 10;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_usersBindingSource, "password", true));
            this.passwordTextBox1.Location = new System.Drawing.Point(681, 258);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(149, 22);
            this.passwordTextBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin Settings";
            // 
            // FrmSettingsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 552);
            this.Controls.Add(usernameLabel1);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(passwordLabel1);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.admin_usersDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.student_usersDataGridView);
            this.Controls.Add(this.student_usersBindingNavigator);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettingsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettingsAdmin";
            this.Load += new System.EventHandler(this.FrmSettingsAdmin_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAffairsResSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersBindingNavigator)).EndInit();
            this.student_usersBindingNavigator.ResumeLayout(false);
            this.student_usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private StudentAffairsResSystemDataSet studentAffairsResSystemDataSet;
        private System.Windows.Forms.BindingSource student_usersBindingSource;
        private StudentAffairsResSystemDataSetTableAdapters.student_usersTableAdapter student_usersTableAdapter;
        private StudentAffairsResSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator student_usersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton student_usersBindingNavigatorSaveItem;
        private StudentAffairsResSystemDataSetTableAdapters.admin_usersTableAdapter admin_usersTableAdapter;
        private System.Windows.Forms.DataGridView student_usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource admin_usersBindingSource;
        private System.Windows.Forms.DataGridView admin_usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Label label3;
    }
}