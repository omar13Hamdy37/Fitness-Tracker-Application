namespace FitnessApplication
{
    partial class AcademiesViewSessions
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
            this.sfComboBoxSortBy = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sfComboBoxLimit = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfButtonShow = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxSortBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // sfComboBoxSortBy
            // 
            this.sfComboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfComboBoxSortBy.BackColor = System.Drawing.Color.White;
            this.sfComboBoxSortBy.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBoxSortBy.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBoxSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfComboBoxSortBy.Location = new System.Drawing.Point(238, 56);
            this.sfComboBoxSortBy.Name = "sfComboBoxSortBy";
            this.sfComboBoxSortBy.Size = new System.Drawing.Size(161, 29);
            this.sfComboBoxSortBy.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfComboBoxSortBy.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxSortBy.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBoxSortBy.TabIndex = 0;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortBy.Location = new System.Drawing.Point(44, 56);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(100, 29);
            this.labelSortBy.TabIndex = 22;
            this.labelSortBy.Text = "Sort by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Limit Sessions:";
            // 
            // sfComboBoxLimit
            // 
            this.sfComboBoxLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfComboBoxLimit.BackColor = System.Drawing.Color.White;
            this.sfComboBoxLimit.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBoxLimit.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBoxLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfComboBoxLimit.Location = new System.Drawing.Point(238, 108);
            this.sfComboBoxLimit.Name = "sfComboBoxLimit";
            this.sfComboBoxLimit.Size = new System.Drawing.Size(161, 29);
            this.sfComboBoxLimit.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxLimit.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfComboBoxLimit.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxLimit.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBoxLimit.TabIndex = 23;
            // 
            // sfButtonShow
            // 
            this.sfButtonShow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonShow.Location = new System.Drawing.Point(144, 159);
            this.sfButtonShow.Name = "sfButtonShow";
            this.sfButtonShow.Size = new System.Drawing.Size(171, 33);
            this.sfButtonShow.TabIndex = 25;
            this.sfButtonShow.Text = "Show";
            this.sfButtonShow.Click += new System.EventHandler(this.sfButtonShow_Click);
            // 
            // AcademiesViewSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 226);
            this.Controls.Add(this.sfButtonShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfComboBoxLimit);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.sfComboBoxSortBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcademiesViewSessions";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "View Sessions";
            this.Load += new System.EventHandler(this.AcademiesViewSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxSortBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxSortBy;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxLimit;
        private Syncfusion.WinForms.Controls.SfButton sfButtonShow;
    }
}