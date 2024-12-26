namespace FitnessApplication
{
    partial class Academies
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
            this.labelWelcomeAcademy = new System.Windows.Forms.Label();
            this.buttonViewProfile = new System.Windows.Forms.Button();
            this.buttonPostSession = new System.Windows.Forms.Button();
            this.buttonViewSession = new System.Windows.Forms.Button();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcomeAcademy
            // 
            this.labelWelcomeAcademy.AutoSize = true;
            this.labelWelcomeAcademy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeAcademy.ForeColor = System.Drawing.Color.IndianRed;
            this.labelWelcomeAcademy.Location = new System.Drawing.Point(19, 54);
            this.labelWelcomeAcademy.Name = "labelWelcomeAcademy";
            this.labelWelcomeAcademy.Size = new System.Drawing.Size(271, 38);
            this.labelWelcomeAcademy.TabIndex = 0;
            this.labelWelcomeAcademy.Text = "Welcome, Name";
            // 
            // buttonViewProfile
            // 
            this.buttonViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProfile.Location = new System.Drawing.Point(62, 121);
            this.buttonViewProfile.Name = "buttonViewProfile";
            this.buttonViewProfile.Size = new System.Drawing.Size(206, 49);
            this.buttonViewProfile.TabIndex = 1;
            this.buttonViewProfile.Text = "View Profile";
            this.buttonViewProfile.UseVisualStyleBackColor = true;
            this.buttonViewProfile.Click += new System.EventHandler(this.buttonViewProfile_Click);
            // 
            // buttonPostSession
            // 
            this.buttonPostSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostSession.Location = new System.Drawing.Point(26, 223);
            this.buttonPostSession.Name = "buttonPostSession";
            this.buttonPostSession.Size = new System.Drawing.Size(206, 49);
            this.buttonPostSession.TabIndex = 2;
            this.buttonPostSession.Text = "Post Session";
            this.buttonPostSession.UseVisualStyleBackColor = true;
            this.buttonPostSession.Click += new System.EventHandler(this.buttonPostSession_Click);
            // 
            // buttonViewSession
            // 
            this.buttonViewSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewSession.Location = new System.Drawing.Point(26, 322);
            this.buttonViewSession.Name = "buttonViewSession";
            this.buttonViewSession.Size = new System.Drawing.Size(206, 49);
            this.buttonViewSession.TabIndex = 3;
            this.buttonViewSession.Text = "View Sessions";
            this.buttonViewSession.UseVisualStyleBackColor = true;
            this.buttonViewSession.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Location = new System.Drawing.Point(99, 54);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(490, 492);
            this.tabControlAdv1.TabIndex = 4;
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.buttonViewProfile);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 29);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(487, 461);
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 29);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(487, 461);
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // Academies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 653);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.buttonViewSession);
            this.Controls.Add(this.buttonPostSession);
            this.Controls.Add(this.labelWelcomeAcademy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Academies";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Academies";
            this.Load += new System.EventHandler(this.Academies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeAcademy;
        private System.Windows.Forms.Button buttonViewProfile;
        private System.Windows.Forms.Button buttonPostSession;
        private System.Windows.Forms.Button buttonViewSession;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
    }
}