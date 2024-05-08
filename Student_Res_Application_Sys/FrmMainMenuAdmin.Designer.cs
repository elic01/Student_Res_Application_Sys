namespace Student_Res_Application_Sys
{
    partial class FrmMainMenuAdmin
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
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSettings = new ReaLTaiizor.Controls.MaterialButton();
            this.BtnAccomodationDetails = new ReaLTaiizor.Controls.MaterialButton();
            this.BtnStudentDetails = new ReaLTaiizor.Controls.MaterialButton();
            this.BtnLogout = new ReaLTaiizor.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.nightControlBox1.Location = new System.Drawing.Point(756, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 43);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Res_Application_Sys.Properties.Resources.menu_burger;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.AutoSize = false;
            this.BtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSettings.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSettings.Depth = 0;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.HighEmphasis = true;
            this.BtnSettings.Icon = global::Student_Res_Application_Sys.Properties.Resources.settings_7_512;
            this.BtnSettings.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnSettings.Location = new System.Drawing.Point(600, 231);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSettings.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSettings.Size = new System.Drawing.Size(206, 114);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSettings.UseAccentColor = false;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // BtnAccomodationDetails
            // 
            this.BtnAccomodationDetails.AutoSize = false;
            this.BtnAccomodationDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAccomodationDetails.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAccomodationDetails.Depth = 0;
            this.BtnAccomodationDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccomodationDetails.HighEmphasis = true;
            this.BtnAccomodationDetails.Icon = global::Student_Res_Application_Sys.Properties.Resources.building;
            this.BtnAccomodationDetails.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnAccomodationDetails.Location = new System.Drawing.Point(324, 231);
            this.BtnAccomodationDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAccomodationDetails.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnAccomodationDetails.Name = "BtnAccomodationDetails";
            this.BtnAccomodationDetails.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAccomodationDetails.Size = new System.Drawing.Size(206, 114);
            this.BtnAccomodationDetails.TabIndex = 3;
            this.BtnAccomodationDetails.Text = "Accomodation Details";
            this.BtnAccomodationDetails.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAccomodationDetails.UseAccentColor = false;
            this.BtnAccomodationDetails.UseVisualStyleBackColor = true;
            this.BtnAccomodationDetails.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // BtnStudentDetails
            // 
            this.BtnStudentDetails.AutoSize = false;
            this.BtnStudentDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStudentDetails.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnStudentDetails.Depth = 0;
            this.BtnStudentDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentDetails.HighEmphasis = true;
            this.BtnStudentDetails.Icon = global::Student_Res_Application_Sys.Properties.Resources.users_alt;
            this.BtnStudentDetails.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnStudentDetails.Location = new System.Drawing.Point(37, 231);
            this.BtnStudentDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnStudentDetails.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnStudentDetails.Name = "BtnStudentDetails";
            this.BtnStudentDetails.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnStudentDetails.Size = new System.Drawing.Size(206, 114);
            this.BtnStudentDetails.TabIndex = 2;
            this.BtnStudentDetails.Text = "Student Details";
            this.BtnStudentDetails.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnStudentDetails.UseAccentColor = false;
            this.BtnStudentDetails.UseVisualStyleBackColor = true;
            this.BtnStudentDetails.Click += new System.EventHandler(this.BtnStudentDetails_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.AutoSize = false;
            this.BtnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogout.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLogout.Depth = 0;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.HighEmphasis = true;
            this.BtnLogout.Icon = global::Student_Res_Application_Sys.Properties.Resources.logout_512;
            this.BtnLogout.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnLogout.Location = new System.Drawing.Point(707, 485);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLogout.Size = new System.Drawing.Size(175, 75);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Exit";
            this.BtnLogout.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLogout.UseAccentColor = false;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome ";
            // 
            // FrmMainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnAccomodationDetails);
            this.Controls.Add(this.BtnStudentDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialButton BtnStudentDetails;
        private ReaLTaiizor.Controls.MaterialButton BtnAccomodationDetails;
        private ReaLTaiizor.Controls.MaterialButton BtnSettings;
        private ReaLTaiizor.Controls.MaterialButton BtnLogout;
        private System.Windows.Forms.Label label2;
    }
}