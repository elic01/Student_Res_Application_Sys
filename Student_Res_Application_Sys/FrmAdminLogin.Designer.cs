namespace Student_Res_Application_Sys
{
    partial class FrmAdminLogin
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
            this.panel1Admin = new System.Windows.Forms.Panel();
            this.BtnLoginAdmin = new ReaLTaiizor.Controls.MaterialButton();
            this.TxtBoxPassAdmin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.TxtBoxUsernameAdmin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Admin
            // 
            this.panel1Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1Admin.Controls.Add(this.BtnLoginAdmin);
            this.panel1Admin.Controls.Add(this.TxtBoxPassAdmin);
            this.panel1Admin.Controls.Add(this.TxtBoxUsernameAdmin);
            this.panel1Admin.Controls.Add(this.label1);
            this.panel1Admin.Location = new System.Drawing.Point(35, 23);
            this.panel1Admin.Name = "panel1Admin";
            this.panel1Admin.Size = new System.Drawing.Size(278, 339);
            this.panel1Admin.TabIndex = 1;
            // 
            // BtnLoginAdmin
            // 
            this.BtnLoginAdmin.AutoSize = false;
            this.BtnLoginAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoginAdmin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLoginAdmin.Depth = 0;
            this.BtnLoginAdmin.HighEmphasis = true;
            this.BtnLoginAdmin.Icon = global::Student_Res_Application_Sys.Properties.Resources.login_512;
            this.BtnLoginAdmin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnLoginAdmin.Location = new System.Drawing.Point(55, 248);
            this.BtnLoginAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoginAdmin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnLoginAdmin.Name = "BtnLoginAdmin";
            this.BtnLoginAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLoginAdmin.Size = new System.Drawing.Size(139, 40);
            this.BtnLoginAdmin.TabIndex = 5;
            this.BtnLoginAdmin.Text = "Login";
            this.BtnLoginAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLoginAdmin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLoginAdmin.UseAccentColor = false;
            this.BtnLoginAdmin.UseVisualStyleBackColor = true;
            this.BtnLoginAdmin.Click += new System.EventHandler(this.BtnLoginAdmin_Click);
            // 
            // TxtBoxPassAdmin
            // 
            this.TxtBoxPassAdmin.AnimateReadOnly = false;
            this.TxtBoxPassAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBoxPassAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBoxPassAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBoxPassAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBoxPassAdmin.Depth = 0;
            this.TxtBoxPassAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBoxPassAdmin.HideSelection = true;
            this.TxtBoxPassAdmin.Hint = "Password";
            this.TxtBoxPassAdmin.LeadingIcon = null;
            this.TxtBoxPassAdmin.Location = new System.Drawing.Point(14, 150);
            this.TxtBoxPassAdmin.MaxLength = 32767;
            this.TxtBoxPassAdmin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtBoxPassAdmin.Name = "TxtBoxPassAdmin";
            this.TxtBoxPassAdmin.PasswordChar = '●';
            this.TxtBoxPassAdmin.PrefixSuffixText = null;
            this.TxtBoxPassAdmin.ReadOnly = false;
            this.TxtBoxPassAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBoxPassAdmin.SelectedText = "";
            this.TxtBoxPassAdmin.SelectionLength = 0;
            this.TxtBoxPassAdmin.SelectionStart = 0;
            this.TxtBoxPassAdmin.ShortcutsEnabled = true;
            this.TxtBoxPassAdmin.Size = new System.Drawing.Size(250, 48);
            this.TxtBoxPassAdmin.TabIndex = 2;
            this.TxtBoxPassAdmin.TabStop = false;
            this.TxtBoxPassAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxPassAdmin.TrailingIcon = global::Student_Res_Application_Sys.Properties.Resources.key_512;
            this.TxtBoxPassAdmin.UseSystemPasswordChar = true;
            // 
            // TxtBoxUsernameAdmin
            // 
            this.TxtBoxUsernameAdmin.AnimateReadOnly = false;
            this.TxtBoxUsernameAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBoxUsernameAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TxtBoxUsernameAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBoxUsernameAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBoxUsernameAdmin.Depth = 0;
            this.TxtBoxUsernameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBoxUsernameAdmin.HideSelection = true;
            this.TxtBoxUsernameAdmin.Hint = "Username";
            this.TxtBoxUsernameAdmin.LeadingIcon = null;
            this.TxtBoxUsernameAdmin.Location = new System.Drawing.Point(14, 78);
            this.TxtBoxUsernameAdmin.MaxLength = 32767;
            this.TxtBoxUsernameAdmin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtBoxUsernameAdmin.Name = "TxtBoxUsernameAdmin";
            this.TxtBoxUsernameAdmin.PasswordChar = '\0';
            this.TxtBoxUsernameAdmin.PrefixSuffixText = null;
            this.TxtBoxUsernameAdmin.ReadOnly = false;
            this.TxtBoxUsernameAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBoxUsernameAdmin.SelectedText = "";
            this.TxtBoxUsernameAdmin.SelectionLength = 0;
            this.TxtBoxUsernameAdmin.SelectionStart = 0;
            this.TxtBoxUsernameAdmin.ShortcutsEnabled = true;
            this.TxtBoxUsernameAdmin.Size = new System.Drawing.Size(250, 48);
            this.TxtBoxUsernameAdmin.TabIndex = 1;
            this.TxtBoxUsernameAdmin.TabStop = false;
            this.TxtBoxUsernameAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxUsernameAdmin.TrailingIcon = global::Student_Res_Application_Sys.Properties.Resources.user;
            this.TxtBoxUsernameAdmin.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 411);
            this.Controls.Add(this.panel1Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminLogin";
            this.Load += new System.EventHandler(this.FrmAdminLogin_Load);
            this.panel1Admin.ResumeLayout(false);
            this.panel1Admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Admin;
        private ReaLTaiizor.Controls.MaterialButton BtnLoginAdmin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtBoxPassAdmin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtBoxUsernameAdmin;
        private System.Windows.Forms.Label label1;
    }
}