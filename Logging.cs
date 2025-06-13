﻿using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Syncfusion.Windows.Forms.Tools.XPMenus;
namespace FitnessApplication
{
    public partial class Logging : SfForm
    {
        Controller controller;
        Logging logingform;
     
        int ID, ExerciseID, MinutesExercised, PointsAwarded;
            decimal CaloriesBurned;
        int caloriesentered;
        int suggestedcalories;
        string datetimetoinsert;
        int streak;
        int allowedcalories;
        Members basemembersform;
        // For now as there is no login screen
        string Username;
        string Name;
        int resultoflogexercise;
        int resultoflogcalories;
        private void autoLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
           

        }

   

        private void logbothbutton_Click(object sender, EventArgs e)
        {
            bool valid = true;

            //suggestedcalories = controller.GetSuggestedCalories(ID);
            allowedcalories = controller.GetAllowedCalories(ID);
      

           if (memberlogexercisescombo.SelectedIndex ==-1&&memberlogcaloriestextbox.Text=="")
            {
                MessageBox.Show("Please Select an Exercise to Log or enter your calories ");
                return;
            }
            if(memberlogcaloriestextbox.Text != "")
            {
                if (int.TryParse(memberlogcaloriestextbox.Text, out caloriesentered))
                {
                    datetimetoinsert = datetimelog.Text;
                    if (datetimelog.Text == "")
                    {
                        MessageBox.Show("Please Select the Date");
                        return;
                    }
                    else
                    {

                        resultoflogcalories= controller.LogCalories(ID, datetimetoinsert, caloriesentered, allowedcalories);
                    }
                }
                else
                {
                        MessageBox.Show("Invalid calories entered. Please enter a valid number.");
                        return;
                }

                

            }

            if ((memberminsexercisedtextbox.Text != ""&& memberlogexercisescombo.SelectedIndex != -1))
            {

               if (int.TryParse(memberminsexercisedtextbox.Text, out MinutesExercised)&& MinutesExercised!=0)
               {
                    datetimetoinsert = datetimelog.Text;
                    if(datetimelog.Text=="")
                    {
                        MessageBox.Show("Please Select the Date");
                        return;
                    }
                    CaloriesBurned = (MinutesExercised) * controller.GetCaloriesBurnedByExerciseID((string)memberlogexercisescombo.SelectedValue);
           
                    actualcalorieslabel.Text = CaloriesBurned.ToString();
                    PointsAwarded = (MinutesExercised)* controller.Getpointsearned((string)memberlogexercisescombo.SelectedValue);
                    actualpointslabel.Text = PointsAwarded.ToString();
                    
                    resultoflogexercise = controller.LogMemberExercise(ID, ExerciseID, datetimetoinsert, MinutesExercised, CaloriesBurned, PointsAwarded);
               }
                else
                {

                    MessageBox.Show("Invalid minutes entered. Please enter a valid number .");
                    return;
                }
               

            }
            else if(memberlogexercisescombo.SelectedIndex != -1&& memberminsexercisedtextbox.Text == "")
            {
                
                MessageBox.Show(" Please enter the number of minutes, if no exercise enter 0 .");
                return;
            }
            if (resultoflogexercise > 0)
            {
                calorieslabel1.Visible = true;
                actualcalorieslabel.Visible = true;
                pointsawardedlabel1.Visible = true;
                actualpointslabel.Visible = true;
            }
                    
            //    MessageBox.Show("Exercise logged successfully! Points awarded: " + PointsAwarded.ToString());
            if (resultoflogexercise == 1 && resultoflogcalories != 1)
            {
                MessageBox.Show("Exercise logged successfully! ");
                controller.UpdateMemberPoints(ID, PointsAwarded);

                memberminsexercisedtextbox.Text = "";
            }
            else if (resultoflogexercise != 1 && resultoflogcalories == 1&& MinutesExercised==0)
            {
                MessageBox.Show(" calories logged successfully!.");
                Loadlog();
            }
            else if(resultoflogexercise == 1 && resultoflogcalories == 1&& MinutesExercised!=0)
            {
                MessageBox.Show(" Exercise and Calories logged successfully!.");
                controller.UpdateMemberPoints(ID, PointsAwarded);
            }
            else
            {
                MessageBox.Show(" Error logging try again!.");
            }
         

            

        }

     
                   
       
     

        public Logging(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;

            Loadlog();


        }

        private void memberviewstreakbutton_Click(object sender, EventArgs e)
        { 
             streak =controller.GetStreak(ID);
            if (streak > 0)
            {
                MessageBox.Show(" Your streak is " + streak.ToString() + " Keep it up !");
            }
            else
            {
                MessageBox.Show(" No streak :( , Log your calories for today !");
            }
        }

        public void Loadlog()
        {
    //        string[] exerciseNames =
    //            {
    //"Running", "Swimming", "Cycling", "Jumping Rope", "Squats",
    //"Push-ups", "Pull-ups", "Burpees", "Lunges", "Planks",
    //"Deadlifts", "Box Jumps", "Mountain Climbers", "Kettlebell Swings",
    //"Bicep Curls", "Tricep Dips", "Leg Raises", "Sprints", "Treadmill Walking",
    //"Rowing", "Zumba", "Yoga", "Pilates", "Kickboxing", "Tai Chi",
    //"Barbell Rows", "Chest Press", "Leg Press", "Cable Machine Rows",
    //"Medicine Ball Slams", "Glute Bridges", "Seated Shoulder Press",
    //"Tuck Jumps", "Russian Twists", "Climbing Stairs", "Bodyweight Squats",
    //"High Knees", "Side Lunges", "Trampoline Jumping", "Handstand Push-ups"," " 
    //                 };


            ID = controller.GetMemberID(Username);
            Name = controller.GetMemberName(ID);
            memberlogexercisescombo.DataSource = controller.GetExercises();
            memberlogexercisescombo.DisplayMember = "ExerciseName";
            memberlogexercisescombo.ValueMember = "ExerciseName";
      
            datetimelog.Format = DateTimePickerFormat.Custom;
            datetimelog.CustomFormat = "yyyy-MM-dd HH:mm:ss";
         
            memberlogexercisescombo.SelectedIndex = -1;
            memberminsexercisedtextbox.Visible = false;
            minexerclabel.Visible = false;
            calorieslabel1.Visible = false;
            actualcalorieslabel.Visible = false;
            pointsawardedlabel1.Visible = false;
            actualpointslabel.Visible = false;
            prompttoenterminslabel.Visible = false;

        }
        private void memberlogexercisescombo_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            memberminsexercisedtextbox.Visible = false;
            minexerclabel.Visible = false;
            calorieslabel1.Visible = false;
            actualcalorieslabel.Visible = false;
            pointsawardedlabel1.Visible = false;
            actualpointslabel.Visible = false;
            prompttoenterminslabel.Visible = false;

            if (memberlogexercisescombo.SelectedIndex > -1) 
            {        
                ExerciseID = controller.GetExerciseID(memberlogexercisescombo.SelectedValue.ToString());
                memberminsexercisedtextbox.Visible = true;
                prompttoenterminslabel.Visible=true;
              




                minexerclabel.Visible = true;
              

            }
           

        }
        private void Logging_Load(object sender, EventArgs e)
        {

            // Set form background color to a pastel blue shade
            this.BackColor = Color.FromArgb(220, 230, 240);

            // Customize buttons
            var buttons = new[] { memberviewstreakbutton, logbothbutton };
            foreach (var button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(150, 170, 180); // Lighter blue border
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 170, 180); // Lighter blue hover color
                button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(100, 120, 140); // Lighter blue button color
            }

            // Customize labels (autoLabels)
            var labels = new[] { autoLabel1, autoLabel3, autoLabel8, minexerclabel, calorieslabel1, pointsawardedlabel1 };
            foreach (var label in labels)
            {
                label.ForeColor = Color.FromArgb(50, 50, 50); // Darker gray text color
            }

            // Customize textboxes
            var textboxes = new[] { memberlogcaloriestextbox, memberminsexercisedtextbox };
            foreach (var textbox in textboxes)
            {
                textbox.BackColor = Color.FromArgb(200, 210, 220); // Lighter blue textbox background
                textbox.ForeColor = Color.Black; // Black text for textbox
            }

            // Hide prompt label initially (assuming prompt label is prompttoenterminslabel)
            prompttoenterminslabel.Visible = false;


        }
    }
}
