namespace FitnessApplication
{
    partial class AcademiesSessionStats
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
            this.labelsayingattending = new System.Windows.Forms.Label();
            this.labelNumMembersAttending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelsayingattending
            // 
            this.labelsayingattending.AutoSize = true;
            this.labelsayingattending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsayingattending.Location = new System.Drawing.Point(5, 38);
            this.labelsayingattending.Name = "labelsayingattending";
            this.labelsayingattending.Size = new System.Drawing.Size(260, 22);
            this.labelsayingattending.TabIndex = 89;
            this.labelsayingattending.Text = "Number of members attending: ";
            // 
            // labelNumMembersAttending
            // 
            this.labelNumMembersAttending.AutoSize = true;
            this.labelNumMembersAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumMembersAttending.Location = new System.Drawing.Point(287, 38);
            this.labelNumMembersAttending.Name = "labelNumMembersAttending";
            this.labelNumMembersAttending.Size = new System.Drawing.Size(20, 22);
            this.labelNumMembersAttending.TabIndex = 90;
            this.labelNumMembersAttending.Text = "1";
            // 
            // AcademiesSessionStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 620);
            this.Controls.Add(this.labelNumMembersAttending);
            this.Controls.Add(this.labelsayingattending);
            this.Name = "AcademiesSessionStats";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "AcademiesSessionStats";
            this.Load += new System.EventHandler(this.AcademiesSessionStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsayingattending;
        private System.Windows.Forms.Label labelNumMembersAttending;
    }
}