﻿using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;

namespace FitnessApplication
{
    public partial class AcademiesOverallStats : SfForm
    {
        private Controller controller;
        private string Username; private int AcademyID;

        private int NumSessionsDone, NumSessionsOngoing, AvgNumMembers;

        public AcademiesOverallStats(string Username, int AcademyID)
        {
            InitializeComponent();
            this.Username = Username; this.AcademyID = AcademyID;
            controller = new Controller();

            Load_Managerial();
            Update_Form();
            PopulateMemberAgeChart();
            PopulateGenderPieChart();
        }

        private void AcademiesOverallStats_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.LightCoral;
            this.Style.TitleBar.ForeColor = Color.White;

            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

            this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
        }

        private void Load_Managerial()
        {
            NumSessionsDone = controller.GetCountDoneSessions(AcademyID, DateTime.Today);
            NumSessionsOngoing = controller.GetAllSessionsCount(AcademyID) - NumSessionsDone;
            AvgNumMembers = controller.GetAverageMembersPerSession(AcademyID);
        }

        private void Update_Form()
        {
            labelAvgNumMembers.Text = AvgNumMembers.ToString();
            labelOngoingSessions.Text = NumSessionsOngoing.ToString();
            labelSessionsDone.Text = NumSessionsDone.ToString();
        }

        private void PopulateMemberAgeChart()
        {
            DataTable query_result = controller.GetMembersAgeGroupOfAcademy(AcademyID);
            if (query_result != null)
            {
                // hay return Age, NumOfMembers
                for (int i = 0; i < query_result.Rows.Count; i++)
                {
                    chartMembersAge.Series["Members"].Points.AddXY(
                        (int)query_result.Rows[i]["Age"],
                        (int)query_result.Rows[i]["NumberOfMembers"]
                    );
                }

                chartMembersAge.ChartAreas[0].AxisX.Title = "Age";
                chartMembersAge.ChartAreas[0].AxisY.Title = "Number Attending";

                chartMembersAge.ChartAreas[0].AxisY.Interval = 1;  // Set the interval for y-axis
            }
        }

        private void PopulateGenderPieChart()
        {
            DataTable query_result = controller.GetMembersGenderGroupOfAcademy(AcademyID);
            if (query_result != null)
            {
                int maleCount = 0;
                int femaleCount = 0;

                for (int i = 0; i < query_result.Rows.Count; i++)
                {
                    string gender = (string)query_result.Rows[i]["Gender"];
                    int numberOfMembers = (int)query_result.Rows[i]["NumberOfMembers"];

                    if (gender == "M")
                    {
                        maleCount += numberOfMembers;
                    }
                    else if (gender == "F")
                    {
                        femaleCount += numberOfMembers;
                    }
                }

                chartGender.Series["Gender"].Points.Clear();

                if (maleCount != 0)
                {
                    chartGender.Series["Gender"].Points.AddXY("Male", maleCount);
                    chartGender.Series["Gender"].Points[0].Color = System.Drawing.Color.LightSkyBlue;
                }
                if (femaleCount != 0)
                {
                    chartGender.Series["Gender"].Points.AddXY("Female", femaleCount);
                    int index;
                    if (maleCount == 0)
                        index = 0;
                    else
                        index = 1;
                    chartGender.Series["Gender"].Points[index].Color = System.Drawing.Color.Pink;
                }

                labelNumMales.Text = maleCount.ToString();
                labelNumFemales.Text = femaleCount.ToString();

                chartGender.Series["Gender"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }
    }
}