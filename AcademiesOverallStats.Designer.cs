namespace FitnessApplication
{
    partial class AcademiesOverallStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelsayingattending = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSessionsDone = new System.Windows.Forms.Label();
            this.labelAvgNumMembers = new System.Windows.Forms.Label();
            this.labelOngoingSessions = new System.Windows.Forms.Label();
            this.chartMembersAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNumMales = new System.Windows.Forms.Label();
            this.labelNumFemales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembersAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsayingattending
            // 
            this.labelsayingattending.AutoSize = true;
            this.labelsayingattending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsayingattending.Location = new System.Drawing.Point(5, 29);
            this.labelsayingattending.Name = "labelsayingattending";
            this.labelsayingattending.Size = new System.Drawing.Size(206, 22);
            this.labelsayingattending.TabIndex = 90;
            this.labelsayingattending.Text = "Total no. sessions done:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 91;
            this.label1.Text = "Total no. sessions ongoing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Average no. members per session:";
            // 
            // labelSessionsDone
            // 
            this.labelSessionsDone.AutoSize = true;
            this.labelSessionsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionsDone.Location = new System.Drawing.Point(314, 29);
            this.labelSessionsDone.Name = "labelSessionsDone";
            this.labelSessionsDone.Size = new System.Drawing.Size(20, 22);
            this.labelSessionsDone.TabIndex = 95;
            this.labelSessionsDone.Text = "1";
            // 
            // labelAvgNumMembers
            // 
            this.labelAvgNumMembers.AutoSize = true;
            this.labelAvgNumMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgNumMembers.Location = new System.Drawing.Point(314, 117);
            this.labelAvgNumMembers.Name = "labelAvgNumMembers";
            this.labelAvgNumMembers.Size = new System.Drawing.Size(20, 22);
            this.labelAvgNumMembers.TabIndex = 96;
            this.labelAvgNumMembers.Text = "1";
            // 
            // labelOngoingSessions
            // 
            this.labelOngoingSessions.AutoSize = true;
            this.labelOngoingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOngoingSessions.Location = new System.Drawing.Point(314, 71);
            this.labelOngoingSessions.Name = "labelOngoingSessions";
            this.labelOngoingSessions.Size = new System.Drawing.Size(20, 22);
            this.labelOngoingSessions.TabIndex = 97;
            this.labelOngoingSessions.Text = "1";
            // 
            // chartMembersAge
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMembersAge.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMembersAge.Legends.Add(legend2);
            this.chartMembersAge.Location = new System.Drawing.Point(9, 162);
            this.chartMembersAge.Name = "chartMembersAge";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Members";
            this.chartMembersAge.Series.Add(series2);
            this.chartMembersAge.Size = new System.Drawing.Size(537, 337);
            this.chartMembersAge.TabIndex = 98;
            this.chartMembersAge.Text = "Age of members attending";
            // 
            // labelNumMales
            // 
            this.labelNumMales.AutoSize = true;
            this.labelNumMales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumMales.Location = new System.Drawing.Point(592, 651);
            this.labelNumMales.Name = "labelNumMales";
            this.labelNumMales.Size = new System.Drawing.Size(20, 22);
            this.labelNumMales.TabIndex = 103;
            this.labelNumMales.Text = "1";
            // 
            // labelNumFemales
            // 
            this.labelNumFemales.AutoSize = true;
            this.labelNumFemales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFemales.Location = new System.Drawing.Point(592, 704);
            this.labelNumFemales.Name = "labelNumFemales";
            this.labelNumFemales.Size = new System.Drawing.Size(20, 22);
            this.labelNumFemales.TabIndex = 102;
            this.labelNumFemales.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 101;
            this.label3.Text = "Num. Females: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 651);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Num. Males:";
            // 
            // chartGender
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGender.Legends.Add(legend3);
            this.chartGender.Location = new System.Drawing.Point(9, 505);
            this.chartGender.Name = "chartGender";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Gender";
            this.chartGender.Series.Add(series3);
            this.chartGender.Size = new System.Drawing.Size(476, 301);
            this.chartGender.TabIndex = 99;
            this.chartGender.Text = "chart1";
            // 
            // AcademiesOverallStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 823);
            this.Controls.Add(this.labelNumMales);
            this.Controls.Add(this.labelNumFemales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.chartMembersAge);
            this.Controls.Add(this.labelOngoingSessions);
            this.Controls.Add(this.labelAvgNumMembers);
            this.Controls.Add(this.labelSessionsDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsayingattending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcademiesOverallStats";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Overall Stats";
            this.Load += new System.EventHandler(this.AcademiesOverallStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMembersAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsayingattending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSessionsDone;
        private System.Windows.Forms.Label labelAvgNumMembers;
        private System.Windows.Forms.Label labelOngoingSessions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMembersAge;
        private System.Windows.Forms.Label labelNumMales;
        private System.Windows.Forms.Label labelNumFemales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
    }
}