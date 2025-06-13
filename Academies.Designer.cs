﻿namespace FitnessApplication
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
            this.buttonOverallStats = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
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
            this.buttonViewProfile.Location = new System.Drawing.Point(156, 136);
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
            this.buttonPostSession.Location = new System.Drawing.Point(156, 224);
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
            this.buttonViewSession.Location = new System.Drawing.Point(156, 312);
            this.buttonViewSession.Name = "buttonViewSession";
            this.buttonViewSession.Size = new System.Drawing.Size(206, 49);
            this.buttonViewSession.TabIndex = 3;
            this.buttonViewSession.Text = "View Sessions";
            this.buttonViewSession.UseVisualStyleBackColor = true;
            this.buttonViewSession.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOverallStats
            // 
            this.buttonOverallStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverallStats.Location = new System.Drawing.Point(156, 398);
            this.buttonOverallStats.Name = "buttonOverallStats";
            this.buttonOverallStats.Size = new System.Drawing.Size(206, 49);
            this.buttonOverallStats.TabIndex = 4;
            this.buttonOverallStats.Text = "Overall Stats";
            this.buttonOverallStats.UseVisualStyleBackColor = true;
            this.buttonOverallStats.Click += new System.EventHandler(this.buttonOverallStats_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(156, 475);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(206, 49);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Academies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 653);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonOverallStats);
            this.Controls.Add(this.buttonViewProfile);
            this.Controls.Add(this.buttonViewSession);
            this.Controls.Add(this.buttonPostSession);
            this.Controls.Add(this.labelWelcomeAcademy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Academies";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Academies";
            this.Load += new System.EventHandler(this.Academies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeAcademy;
        private System.Windows.Forms.Button buttonViewProfile;
        private System.Windows.Forms.Button buttonPostSession;
        private System.Windows.Forms.Button buttonViewSession;
        private System.Windows.Forms.Button buttonOverallStats;
        private System.Windows.Forms.Button buttonLogout;
    }
}