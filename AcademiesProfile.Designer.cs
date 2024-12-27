namespace FitnessApplication
{
    partial class AcademiesProfile
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAreaExpertise = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAOE = new System.Windows.Forms.TextBox();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonConfirmProfileChanges = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.ProfileTab = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.sfDateTimeOfIssue = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateTimeOfExpiration = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.buttonConfirmCertificate = new System.Windows.Forms.Button();
            this.buttonEditCertificate = new System.Windows.Forms.Button();
            this.textBoxIssuingBody = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelDateIssue = new System.Windows.Forms.Label();
            this.labelIssuingBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCertificate = new System.Windows.Forms.Label();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.sfButtonDeleteAccount = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTab)).BeginInit();
            this.ProfileTab.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(10, 101);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelAreaExpertise
            // 
            this.labelAreaExpertise.AutoSize = true;
            this.labelAreaExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaExpertise.Location = new System.Drawing.Point(10, 142);
            this.labelAreaExpertise.Name = "labelAreaExpertise";
            this.labelAreaExpertise.Size = new System.Drawing.Size(153, 22);
            this.labelAreaExpertise.TabIndex = 2;
            this.labelAreaExpertise.Text = "Area of Expertise:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(10, 190);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(185, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(222, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(185, 190);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(222, 83);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxAOE
            // 
            this.textBoxAOE.Location = new System.Drawing.Point(185, 144);
            this.textBoxAOE.Name = "textBoxAOE";
            this.textBoxAOE.ReadOnly = true;
            this.textBoxAOE.Size = new System.Drawing.Size(222, 22);
            this.textBoxAOE.TabIndex = 6;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(606, 59);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(128, 41);
            this.buttonEditProfile.TabIndex = 7;
            this.buttonEditProfile.Text = "Edit Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonConfirmProfileChanges
            // 
            this.buttonConfirmProfileChanges.Location = new System.Drawing.Point(606, 274);
            this.buttonConfirmProfileChanges.Name = "buttonConfirmProfileChanges";
            this.buttonConfirmProfileChanges.Size = new System.Drawing.Size(128, 41);
            this.buttonConfirmProfileChanges.TabIndex = 8;
            this.buttonConfirmProfileChanges.Text = "Confirm Changes";
            this.buttonConfirmProfileChanges.UseVisualStyleBackColor = true;
            this.buttonConfirmProfileChanges.Visible = false;
            this.buttonConfirmProfileChanges.Click += new System.EventHandler(this.buttonConfirmChanges_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.IndianRed;
            this.labelProfile.Location = new System.Drawing.Point(5, 16);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(73, 25);
            this.labelProfile.TabIndex = 9;
            this.labelProfile.Text = "Profile";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(10, 59);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 22);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(185, 59);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(222, 22);
            this.textBoxUsername.TabIndex = 22;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(10, 293);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 22);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(185, 293);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(222, 22);
            this.textBoxPassword.TabIndex = 24;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(185, 321);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(62, 20);
            this.checkBoxShowPassword.TabIndex = 25;
            this.checkBoxShowPassword.Text = "Show";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // ProfileTab
            // 
            this.ProfileTab.ActiveTabColor = System.Drawing.Color.LightCoral;
            this.ProfileTab.Controls.Add(this.tabPageAdv1);
            this.ProfileTab.Controls.Add(this.tabPageAdv2);
            this.ProfileTab.Controls.Add(this.tabPageAdv3);
            this.ProfileTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTab.FocusOnTabClick = false;
            this.ProfileTab.Location = new System.Drawing.Point(2, 2);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(857, 425);
            this.ProfileTab.TabIndex = 29;
            this.ProfileTab.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.ProfileTab.ThemeName = "TabRendererMetro";
            this.ProfileTab.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.textBoxDescription);
            this.tabPageAdv1.Controls.Add(this.labelName);
            this.tabPageAdv1.Controls.Add(this.labelAreaExpertise);
            this.tabPageAdv1.Controls.Add(this.checkBoxShowPassword);
            this.tabPageAdv1.Controls.Add(this.labelDescription);
            this.tabPageAdv1.Controls.Add(this.textBoxPassword);
            this.tabPageAdv1.Controls.Add(this.textBoxName);
            this.tabPageAdv1.Controls.Add(this.labelPassword);
            this.tabPageAdv1.Controls.Add(this.textBoxAOE);
            this.tabPageAdv1.Controls.Add(this.textBoxUsername);
            this.tabPageAdv1.Controls.Add(this.buttonEditProfile);
            this.tabPageAdv1.Controls.Add(this.labelUsername);
            this.tabPageAdv1.Controls.Add(this.buttonConfirmProfileChanges);
            this.tabPageAdv1.Controls.Add(this.labelProfile);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(854, 397);
            this.tabPageAdv1.Text = "Profile";
            this.tabPageAdv1.ThemesEnabled = false;
            this.tabPageAdv1.Click += new System.EventHandler(this.tabPageAdv1_Click);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.sfDateTimeOfIssue);
            this.tabPageAdv2.Controls.Add(this.sfDateTimeOfExpiration);
            this.tabPageAdv2.Controls.Add(this.buttonConfirmCertificate);
            this.tabPageAdv2.Controls.Add(this.buttonEditCertificate);
            this.tabPageAdv2.Controls.Add(this.textBoxIssuingBody);
            this.tabPageAdv2.Controls.Add(this.textBoxTitle);
            this.tabPageAdv2.Controls.Add(this.labelExpirationDate);
            this.tabPageAdv2.Controls.Add(this.labelDateIssue);
            this.tabPageAdv2.Controls.Add(this.labelIssuingBody);
            this.tabPageAdv2.Controls.Add(this.labelTitle);
            this.tabPageAdv2.Controls.Add(this.labelCertificate);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(854, 397);
            this.tabPageAdv2.Text = "Certificate";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // sfDateTimeOfIssue
            // 
            this.sfDateTimeOfIssue.DateTimeIcon = null;
            this.sfDateTimeOfIssue.Enabled = false;
            this.sfDateTimeOfIssue.Location = new System.Drawing.Point(154, 141);
            this.sfDateTimeOfIssue.Name = "sfDateTimeOfIssue";
            this.sfDateTimeOfIssue.Size = new System.Drawing.Size(222, 24);
            this.sfDateTimeOfIssue.TabIndex = 46;
            this.sfDateTimeOfIssue.ToolTipText = "";
            this.sfDateTimeOfIssue.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.sfDateTimeOfIssue_ValueChanged);
            // 
            // sfDateTimeOfExpiration
            // 
            this.sfDateTimeOfExpiration.DateTimeIcon = null;
            this.sfDateTimeOfExpiration.Enabled = false;
            this.sfDateTimeOfExpiration.Location = new System.Drawing.Point(154, 191);
            this.sfDateTimeOfExpiration.Name = "sfDateTimeOfExpiration";
            this.sfDateTimeOfExpiration.Size = new System.Drawing.Size(222, 24);
            this.sfDateTimeOfExpiration.TabIndex = 45;
            this.sfDateTimeOfExpiration.ToolTipText = "";
            this.sfDateTimeOfExpiration.Click += new System.EventHandler(this.DatePickers_Click);
            this.sfDateTimeOfExpiration.DoubleClick += new System.EventHandler(this.DatePickers_Click);
            // 
            // buttonConfirmCertificate
            // 
            this.buttonConfirmCertificate.Location = new System.Drawing.Point(602, 174);
            this.buttonConfirmCertificate.Name = "buttonConfirmCertificate";
            this.buttonConfirmCertificate.Size = new System.Drawing.Size(128, 41);
            this.buttonConfirmCertificate.TabIndex = 31;
            this.buttonConfirmCertificate.Text = "Confirm Changes";
            this.buttonConfirmCertificate.UseVisualStyleBackColor = true;
            this.buttonConfirmCertificate.Visible = false;
            this.buttonConfirmCertificate.Click += new System.EventHandler(this.buttonConfirmCertificate_Click);
            // 
            // buttonEditCertificate
            // 
            this.buttonEditCertificate.Location = new System.Drawing.Point(602, 52);
            this.buttonEditCertificate.Name = "buttonEditCertificate";
            this.buttonEditCertificate.Size = new System.Drawing.Size(128, 41);
            this.buttonEditCertificate.TabIndex = 30;
            this.buttonEditCertificate.Text = "Edit Certificate";
            this.buttonEditCertificate.UseVisualStyleBackColor = true;
            this.buttonEditCertificate.Click += new System.EventHandler(this.buttonEditCertificate_Click);
            // 
            // textBoxIssuingBody
            // 
            this.textBoxIssuingBody.Location = new System.Drawing.Point(154, 95);
            this.textBoxIssuingBody.Name = "textBoxIssuingBody";
            this.textBoxIssuingBody.ReadOnly = true;
            this.textBoxIssuingBody.Size = new System.Drawing.Size(222, 22);
            this.textBoxIssuingBody.TabIndex = 27;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(154, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(222, 22);
            this.textBoxTitle.TabIndex = 26;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(10, 193);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(138, 22);
            this.labelExpirationDate.TabIndex = 25;
            this.labelExpirationDate.Text = "Expiration Date:";
            // 
            // labelDateIssue
            // 
            this.labelDateIssue.AutoSize = true;
            this.labelDateIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateIssue.Location = new System.Drawing.Point(10, 141);
            this.labelDateIssue.Name = "labelDateIssue";
            this.labelDateIssue.Size = new System.Drawing.Size(120, 22);
            this.labelDateIssue.TabIndex = 24;
            this.labelDateIssue.Text = "Date of Issue:";
            // 
            // labelIssuingBody
            // 
            this.labelIssuingBody.AutoSize = true;
            this.labelIssuingBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuingBody.Location = new System.Drawing.Point(10, 93);
            this.labelIssuingBody.Name = "labelIssuingBody";
            this.labelIssuingBody.Size = new System.Drawing.Size(117, 22);
            this.labelIssuingBody.TabIndex = 23;
            this.labelIssuingBody.Text = "Issuing Body:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(10, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 22);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Title:";
            // 
            // labelCertificate
            // 
            this.labelCertificate.AutoSize = true;
            this.labelCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertificate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCertificate.Location = new System.Drawing.Point(5, 11);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(110, 25);
            this.labelCertificate.TabIndex = 21;
            this.labelCertificate.Text = "Certificate";
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.label1);
            this.tabPageAdv3.Controls.Add(this.sfButtonDeleteAccount);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(854, 397);
            this.tabPageAdv3.Text = "Account Settings";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Account Settings";
            // 
            // sfButtonDeleteAccount
            // 
            this.sfButtonDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonDeleteAccount.Location = new System.Drawing.Point(12, 68);
            this.sfButtonDeleteAccount.Name = "sfButtonDeleteAccount";
            this.sfButtonDeleteAccount.Size = new System.Drawing.Size(168, 41);
            this.sfButtonDeleteAccount.TabIndex = 29;
            this.sfButtonDeleteAccount.Text = "Delete Account";
            this.sfButtonDeleteAccount.Click += new System.EventHandler(this.sfButtonDeleteAccount_Click);
            // 
            // AcademiesProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 429);
            this.Controls.Add(this.ProfileTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcademiesProfile";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.AcademiesProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTab)).EndInit();
            this.ProfileTab.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAreaExpertise;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAOE;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonConfirmProfileChanges;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv ProfileTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private System.Windows.Forms.Button buttonConfirmCertificate;
        private System.Windows.Forms.Button buttonEditCertificate;
        private System.Windows.Forms.TextBox textBoxIssuingBody;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelDateIssue;
        private System.Windows.Forms.Label labelIssuingBody;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCertificate;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton sfButtonDeleteAccount;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeOfIssue;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeOfExpiration;
    }
}