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
using DBapplication;
namespace FitnessApplication
{
    public partial class AcademiesSessionStats : SfForm
    {
        String Username;
        int AcademyID, SessionID;
        // Controller
        Controller controller;

        // Stats
        int NumAttending;
        public AcademiesSessionStats(string Username, int AcademyID, int SessionID)
        {
            InitializeComponent();
            this.Username = Username; this.AcademyID = AcademyID; this.SessionID = SessionID;

            controller = new Controller();
            Load_Info();
            Update_Form();


        }

        private void AcademiesSessionStats_Load(object sender, EventArgs e)
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
        private void Load_Info()
        {
            NumAttending = controller.GetNumberOfMembersAttendingSession(SessionID, AcademyID);
        }

        private void Update_Form()
        {
            labelNumMembersAttending.Text = NumAttending.ToString();
        }
    }
}
