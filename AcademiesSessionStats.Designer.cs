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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelsayingattending = new System.Windows.Forms.Label();
            this.labelNumMembersAttending = new System.Windows.Forms.Label();
            this.chartMembersAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumFemales = new System.Windows.Forms.Label();
            this.labelNumMales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembersAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
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
            // chartMembersAge
            // 
            chartArea7.Name = "ChartArea1";
            this.chartMembersAge.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartMembersAge.Legends.Add(legend7);
            this.chartMembersAge.Location = new System.Drawing.Point(9, 92);
            this.chartMembersAge.Name = "chartMembersAge";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Members";
            this.chartMembersAge.Series.Add(series7);
            this.chartMembersAge.Size = new System.Drawing.Size(537, 337);
            this.chartMembersAge.TabIndex = 93;
            this.chartMembersAge.Text = "Age of members attending";
            // 
            // chartGender
            // 
            chartArea8.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartGender.Legends.Add(legend8);
            this.chartGender.Location = new System.Drawing.Point(28, 435);
            this.chartGender.Name = "chartGender";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Gender";
            this.chartGender.Series.Add(series8);
            this.chartGender.Size = new System.Drawing.Size(476, 301);
            this.chartGender.TabIndex = 94;
            this.chartGender.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Num. Males:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "Num. Females: ";
            // 
            // labelNumFemales
            // 
            this.labelNumFemales.AutoSize = true;
            this.labelNumFemales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFemales.Location = new System.Drawing.Point(611, 634);
            this.labelNumFemales.Name = "labelNumFemales";
            this.labelNumFemales.Size = new System.Drawing.Size(20, 22);
            this.labelNumFemales.TabIndex = 97;
            this.labelNumFemales.Text = "1";
            // 
            // labelNumMales
            // 
            this.labelNumMales.AutoSize = true;
            this.labelNumMales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumMales.Location = new System.Drawing.Point(611, 581);
            this.labelNumMales.Name = "labelNumMales";
            this.labelNumMales.Size = new System.Drawing.Size(20, 22);
            this.labelNumMales.TabIndex = 98;
            this.labelNumMales.Text = "1";
            // 
            // AcademiesSessionStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 817);
            this.Controls.Add(this.labelNumMales);
            this.Controls.Add(this.labelNumFemales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.chartMembersAge);
            this.Controls.Add(this.labelNumMembersAttending);
            this.Controls.Add(this.labelsayingattending);
            this.Name = "AcademiesSessionStats";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Session Stats";
            this.Load += new System.EventHandler(this.AcademiesSessionStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMembersAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsayingattending;
        private System.Windows.Forms.Label labelNumMembersAttending;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMembersAge;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumFemales;
        private System.Windows.Forms.Label labelNumMales;
    }
}