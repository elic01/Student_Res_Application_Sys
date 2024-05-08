namespace Student_Res_Application_Sys
{
    partial class FrmStudentLogin
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
            this.panel1Stdnt = new System.Windows.Forms.Panel();
            this.LinkLblForgotPassStdnt = new System.Windows.Forms.LinkLabel();
            this.BtnLoginStdnt = new ReaLTaiizor.Controls.MaterialButton();
            this.TxtBoxPassStdnt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.TxtBoxUsernameStdnt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1Stdnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Stdnt
            // 
            this.panel1Stdnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1Stdnt.Controls.Add(this.LinkLblForgotPassStdnt);
            this.panel1Stdnt.Controls.Add(this.BtnLoginStdnt);
            this.panel1Stdnt.Controls.Add(this.TxtBoxPassStdnt);
            this.panel1Stdnt.Controls.Add(this.TxtBoxUsernameStdnt);
            this.panel1Stdnt.Controls.Add(this.label1);
            this.panel1Stdnt.Location = new System.Drawing.Point(32, 33);
            this.panel1Stdnt.Name = "panel1Stdnt";
            this.panel1Stdnt.Size = new System.Drawing.Size(275, 324);
            this.panel1Stdnt.TabIndex = 0;
            // 
            // LinkLblForgotPassStdnt
            // 
            this.LinkLblForgotPassStdnt.AutoSize = true;
            this.LinkLblForgotPassStdnt.Location = new System.Drawing.Point(83, 288);
            this.LinkLblForgotPassStdnt.Name = "LinkLblForgotPassStdnt";
            this.LinkLblForgotPassStdnt.Size = new System.Drawing.Size(109, 16);
            this.LinkLblForgotPassStdnt.TabIndex = 6;
            this.LinkLblForgotPassStdnt.TabStop = true;
            this.LinkLblForgotPassStdnt.Text = "Forgot Password";
            this.LinkLblForgotPassStdnt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblForgotPassStdnt_LinkClicked);
            // 
            // BtnLoginStdnt
            // 
            this.BtnLoginStdnt.AutoSize = false;
            this.BtnLoginStdnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoginStdnt.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLoginStdnt.Depth = 0;
            this.BtnLoginStdnt.HighEmphasis = true;
            this.BtnLoginStdnt.Icon = global::Student_Res_Application_Sys.Properties.Resources.login_512;
            this.BtnLoginStdnt.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnLoginStdnt.Location = new System.Drawing.Point(64, 232);
            this.BtnLoginStdnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoginStdnt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnLoginStdnt.Name = "BtnLoginStdnt";
            this.BtnLoginStdnt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLoginStdnt.Size = new System.Drawing.Size(140, 50);
            this.BtnLoginStdnt.TabIndex = 5;
            this.BtnLoginStdnt.Text = "Login";
            this.BtnLoginStdnt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLoginStdnt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLoginStdnt.UseAccentColor = false;
            this.BtnLoginStdnt.UseVisualStyleBackColor = true;
            this.BtnLoginStdnt.Click += new System.EventHandler(this.BtnLoginStdnt_Click);
            // 
            // TxtBoxPassStdnt
            // 
            this.TxtBoxPassStdnt.AnimateReadOnly = false;
            this.TxtBoxPassStdnt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBoxPassStdnt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBoxPassStdnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBoxPassStdnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBoxPassStdnt.Depth = 0;
            this.TxtBoxPassStdnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBoxPassStdnt.HideSelection = true;
            this.TxtBoxPassStdnt.Hint = "Password";
            this.TxtBoxPassStdnt.LeadingIcon = null;
            this.TxtBoxPassStdnt.Location = new System.Drawing.Point(14, 132);
            this.TxtBoxPassStdnt.MaxLength = 32767;
            this.TxtBoxPassStdnt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtBoxPassStdnt.Name = "TxtBoxPassStdnt";
            this.TxtBoxPassStdnt.PasswordChar = '●';
            this.TxtBoxPassStdnt.PrefixSuffixText = null;
            this.TxtBoxPassStdnt.ReadOnly = false;
            this.TxtBoxPassStdnt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBoxPassStdnt.SelectedText = "";
            this.TxtBoxPassStdnt.SelectionLength = 0;
            this.TxtBoxPassStdnt.SelectionStart = 0;
            this.TxtBoxPassStdnt.ShortcutsEnabled = true;
            this.TxtBoxPassStdnt.Size = new System.Drawing.Size(250, 48);
            this.TxtBoxPassStdnt.TabIndex = 2;
            this.TxtBoxPassStdnt.TabStop = false;
            this.TxtBoxPassStdnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxPassStdnt.TrailingIcon = global::Student_Res_Application_Sys.Properties.Resources.key_512;
            this.TxtBoxPassStdnt.UseSystemPasswordChar = true;
            // 
            // TxtBoxUsernameStdnt
            // 
            this.TxtBoxUsernameStdnt.AnimateReadOnly = false;
            this.TxtBoxUsernameStdnt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBoxUsernameStdnt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TxtBoxUsernameStdnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBoxUsernameStdnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBoxUsernameStdnt.Depth = 0;
            this.TxtBoxUsernameStdnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBoxUsernameStdnt.HideSelection = true;
            this.TxtBoxUsernameStdnt.Hint = "Username";
            this.TxtBoxUsernameStdnt.LeadingIcon = null;
            this.TxtBoxUsernameStdnt.Location = new System.Drawing.Point(14, 63);
            this.TxtBoxUsernameStdnt.MaxLength = 32767;
            this.TxtBoxUsernameStdnt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtBoxUsernameStdnt.Name = "TxtBoxUsernameStdnt";
            this.TxtBoxUsernameStdnt.PasswordChar = '\0';
            this.TxtBoxUsernameStdnt.PrefixSuffixText = null;
            this.TxtBoxUsernameStdnt.ReadOnly = false;
            this.TxtBoxUsernameStdnt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBoxUsernameStdnt.SelectedText = "";
            this.TxtBoxUsernameStdnt.SelectionLength = 0;
            this.TxtBoxUsernameStdnt.SelectionStart = 0;
            this.TxtBoxUsernameStdnt.ShortcutsEnabled = true;
            this.TxtBoxUsernameStdnt.Size = new System.Drawing.Size(250, 48);
            this.TxtBoxUsernameStdnt.TabIndex = 1;
            this.TxtBoxUsernameStdnt.TabStop = false;
            this.TxtBoxUsernameStdnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxUsernameStdnt.TrailingIcon = global::Student_Res_Application_Sys.Properties.Resources.user;
            this.TxtBoxUsernameStdnt.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Login";
            // 
            // FrmStudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 413);
            this.Controls.Add(this.panel1Stdnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentLogin";
            this.panel1Stdnt.ResumeLayout(false);
            this.panel1Stdnt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Stdnt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtBoxUsernameStdnt;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtBoxPassStdnt;
        private ReaLTaiizor.Controls.MaterialButton BtnLoginStdnt;
        private System.Windows.Forms.LinkLabel LinkLblForgotPassStdnt;
    }
}