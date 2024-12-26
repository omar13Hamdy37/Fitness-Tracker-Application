using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace FitnessApplication
{
    public partial class AcademiesViewSessions : SfForm
    {
        string Username; int ID;

        AcademySessions SessionsForm;

        string[] sortingOptions = { "Oldest", "Newest" };

        string[] limitOptions = { "None", "5", "10", "15", "20" };
        Controller controller;
        public AcademiesViewSessions(string Username, int ID)
        {
            InitializeComponent();
            this.ID = ID; this.Username = Username;
            controller = new Controller();


            // Add later if fey wa2t: string[] sortingOptions = { "Oldest", "Newest", "Most Attendees", "Least Attendees" };
            sfComboBoxSortBy.DataSource = sortingOptions;
            sfComboBoxSortBy.SelectedIndex = 0;

            sfComboBoxLimit.DataSource = limitOptions;
            sfComboBoxLimit.SelectedIndex = 0;

        }

        private void AcademiesViewSessions_Load(object sender, EventArgs e)
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

        private void sfButtonShow_Click(object sender, EventArgs e)
        {
            string SortBy = (string)sfComboBoxSortBy.SelectedValue;
            string LimitString = (string) sfComboBoxLimit.SelectedValue;
            // Default
            int LimitInt = 0; 

            if (LimitString.ToLower() != "none" )
            {
                LimitInt = int.Parse( LimitString );
            }

            DataTable Sessions = controller.GetAcademySessions(ID, SortBy, LimitInt);

            if (Sessions == null)
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                MessageBoxAdv.MetroColorTable.CaptionBarColor = Color.LightCoral;
                MessageBoxAdv.MetroColorTable.OKButtonBackColor = Color.LightCoral;
                MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.White;
                MessageBoxAdv.Show(this, "You have no sessions posted.", "No Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SessionsForm = new AcademySessions(Username, ID, Sessions);
                SessionsForm.Show();

            }
        }
    }
}
