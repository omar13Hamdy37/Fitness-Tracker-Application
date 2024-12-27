using DBapplication;
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace FitnessApplication
{
    public partial class Academies : SfForm
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        AcademiesPostSession PostSessionForm;
        AcademiesViewSessions ViewSessionsForm;
        AcademiesOverallStats OverallStatsForm;


        int ID;

        string Username;
        string Name;

        public Academies(string Username, int ID)
        {
            InitializeComponent();
            // Initializing controller
            controller = new Controller();
            this.Username = Username;
            this.ID = ID;
            LoadAcademyInfo();
            ConfigureMessageBoxAdv();


        }
        public void UpdateData(string NewUsername)
        {
            Username = NewUsername;
            LoadAcademyInfo();
        }
        private void LoadAcademyInfo()
        {
            // For now username is set since there is no login.
            ID = controller.GetAcademyID(Username);
            Name = controller.GetAcademyName(ID);
            labelWelcomeAcademy.Text = $"Welcome, {Name}";

        }
        private void Academies_Load(object sender, EventArgs e)
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

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            // We will give the profile form access to this form.. in order to update data if needed.
            ProfileForm = new AcademiesProfile(ID, Username, this);

            ProfileForm.Show();


        }

        private void buttonPostSession_Click(object sender, EventArgs e)
        {
            PostSessionForm = new AcademiesPostSession(Username, ID);
            PostSessionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSessionsForm = new AcademiesViewSessions(Username, ID, "academy");
            ViewSessionsForm.Show();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOverallStats_Click(object sender, EventArgs e)
        {
            int numSessions = controller.GetNumberOfSessions(ID);
            int numTotalMembers = controller.GetTotalMembersAttendedAcademy(ID);

            if(numSessions <= 0)
            {
                MessageBoxAdv.Show("You have no sessions posted.", "No Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (numTotalMembers <= 0)
            {
                MessageBoxAdv.Show("No members have attended your sessions.", "No Members.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OverallStatsForm = new AcademiesOverallStats(Username, ID);
                OverallStatsForm.Show();
            }


                

        }
        public static void ConfigureMessageBoxAdv()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            var metroColorTable = MessageBoxAdv.MetroColorTable;
            metroColorTable.BackColor = Color.White;
            metroColorTable.ForeColor = Color.Black;
            metroColorTable.BorderColor = Color.IndianRed;
            metroColorTable.CaptionBarColor = Color.LightCoral;
            metroColorTable.CaptionForeColor = Color.White;
            metroColorTable.OKButtonBackColor = Color.LightCoral;
            metroColorTable.YesButtonBackColor = Color.LightCoral;
            metroColorTable.NoButtonBackColor = Color.LightCoral;


            MessageBoxAdv.MetroColorTable = metroColorTable;
        }
    }
}
    

