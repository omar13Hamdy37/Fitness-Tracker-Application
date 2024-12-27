using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FitnessApplication
{
    public partial class AcademySessions : SfForm
    {
        string Username; int AcademyID;
        DataTable Sessions;
        int sessionID;
        int current_session_index;
        int maxSessionsIndex;
        bool EditMode = false;
        int NumMembersAttending;
        bool Full;
        AcademiesViewSessions BaseSessionsForm;

        // Data of form
        string Description, Address, Date, Time, Duration;
        int limit; float priceFloat;

        Controller controller;

        // Forms
        AcademiesSessionStats StatsForm;
        public AcademySessions(string Username, int ID, DataTable Sessions, int StartingIndex, AcademiesViewSessions BaseSessionsForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.Username = Username; AcademyID= ID;
            this.Sessions = Sessions;
            maxSessionsIndex = Sessions.Rows.Count - 1;
            current_session_index = StartingIndex;
            this.BaseSessionsForm = BaseSessionsForm;
            DatePickers.MinDateTime = DateTime.Now;

            ConfigureMessageBoxAdv();






            Update_Sessions_Num_Label();
            Load_Session();


        }

        private void AcademySessions_Load(object sender, EventArgs e)
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


        private void Load_Session()
        {
            sessionID = (int) Sessions.Rows[current_session_index]["SessionID"];

            textBoxDescription.Text = Sessions.Rows[current_session_index]["Description"].ToString();
            textBoxAddress.Text = Sessions.Rows[current_session_index]["Location"].ToString();
            numericUpDownLimit.Value = (int)Sessions.Rows[current_session_index]["Limit"];
            textBoxPrice.Text = Sessions.Rows[current_session_index]["Price"].ToString();


            checkBoxFree.Checked = textBoxPrice.Text == "EGP 0.00";

            DatePickers.Text = Sessions.Rows[current_session_index]["Date"].ToString();
            DatePickers.Value = (System.DateTime) Sessions.Rows[current_session_index]["Date"];
            DurationPicker.Text = Sessions.Rows[current_session_index]["Duration"].ToString();
            TimePicker.Text = Sessions.Rows[current_session_index]["Time"].ToString();

            NumMembersAttending = controller.GetNumberOfMembersAttendingSession(sessionID, AcademyID);

            Full = (bool) Sessions.Rows[current_session_index]["FullSession"];

            labelStatus.Text = "Status:";
            if(DatePickers.Value > DateTime.Now)
            {
                labelStatus.Text += " Done";
            }
            else if(Full)
            {
                labelStatus.Text += " Full";
            }
            else
            {
                labelStatus.Text += " Open";
            }    
            labelStatus.Text += $" ({NumMembersAttending} Attending)";


        }
        private void Update_Sessions_Num_Label()
        {
            autoLabelNumSession.Text = $"Session #{current_session_index + 1} of {maxSessionsIndex + 1}";
        }



        private void sfButtonNextSession_Click(object sender, EventArgs e)
        {
            if(EditMode)
            {
                sfButtonCancelEditing_Click( sender,  e);

            }
            current_session_index++;
            if (current_session_index > maxSessionsIndex)
            { current_session_index = maxSessionsIndex; }

            Load_Session();
            Update_Sessions_Num_Label();
        }

        private void sfButtonPrevious_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                sfButtonCancelEditing_Click(sender, e);

            }
            current_session_index--;
            if (current_session_index < 0) { current_session_index = 0; }
            Load_Session();
            Update_Sessions_Num_Label();
        }

        private void autoLabelNumSession_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExtSearchSession_Click(object sender, EventArgs e)
        {
            textBoxExtSearchSession.Text = "";
        }

        private void textBoxExtSearchSession_Enter(object sender, EventArgs e)
        {

        }


        private void textBoxExtSearchSession_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBoxExtSearchSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                if (EditMode)
                {
                    sfButtonCancelEditing_Click(sender, e);

                }


                int num_session;
                if (int.TryParse(textBoxExtSearchSession.Text, out num_session))
                {
                    if (num_session < 1)
                    {
                        current_session_index = 0;
                    }
                    else if (num_session > maxSessionsIndex + 1)
                    {

                        current_session_index = maxSessionsIndex;


                    }
                    else
                    {
                        current_session_index = num_session - 1;
                    }
                    Load_Session();
                    Update_Sessions_Num_Label();
                }
            }
        }

        private void sfButtonEdit_Click(object sender, EventArgs e)
        {
            EditMode = true;
            sfButtonEdit.Visible = false;
            sfButtonCancelEditing.Visible = true;
            sfButtonUpload.Visible = true;

            textBoxAddress.ReadOnly = false; textBoxDescription.ReadOnly = false; textBoxPrice.ReadOnly = false;
            numericUpDownLimit.ReadOnly = false;
            checkBoxFree.Enabled = true;
            DatePickers.Enabled = true;
            DurationPicker.Enabled = true; TimePicker.Enabled = true;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void sfButton2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBoxAdv.Show(this,
                "Are you sure you want to delete this session?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                int query_result = controller.DeleteSession(sessionID, AcademyID);
                if(query_result == 1)
                {
                    MessageBoxAdv.Show(this, "Session has been deleted.", "Session deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BaseSessionsForm.ShowResults(current_session_index - 1);
                    this.Close();
                }
                else
                {
                    MessageBoxAdv.Show("Session could not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }    
            }
            else if (result == DialogResult.No)
            {

                MessageBoxAdv.Show(this, "Session deletion canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPrice.Text != "EGP 0.00")
            {
                checkBoxFree.Checked = false;
            }
            else
                { checkBoxFree.Checked = true; }
        }

        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFree.Checked)
            {
                textBoxPrice.Text = "EGP 0.00";
            }
        }

        private void DoneEditing()
        {
            
            EditMode = false;
            sfButtonEdit.Visible = true;
            sfButtonCancelEditing.Visible = false;
            sfButtonUpload.Visible = false;

            textBoxAddress.ReadOnly = true; textBoxDescription.ReadOnly = true; textBoxPrice.ReadOnly = true;
            numericUpDownLimit.ReadOnly = true;
            checkBoxFree.Enabled = false;
            DatePickers.Enabled = false;
            DurationPicker.Enabled = false; TimePicker.Enabled = false;


        }

        private void sfButtonStats_Click(object sender, EventArgs e)
        {
            StatsForm = new AcademiesSessionStats(Username, AcademyID, sessionID);
            StatsForm.Show();
        }

        private void sfButtonCancelEditing_Click(object sender, EventArgs e)
        {
            Load_Session();
            DoneEditing();
        }


        private bool ReadSessionDetails()
        {
            Description = textBoxDescription.Text;
            Address = textBoxAddress.Text;
            limit = (int)numericUpDownLimit.Value;
            

            Date = DatePickers.DateTimeText;
            Time = TimePicker.Text;
            Duration = DurationPicker.Text;
            if (Description == "" || Address == "" || Date == "" || Time == "" || Duration == "" || (textBoxPrice.Text == "" && checkBoxFree.Checked == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void sfButtonUpload_Click(object sender, EventArgs e)
        {
            int result;
            if (ReadSessionDetails())
            {
                if (limit <= 0)
                {

                    MessageBoxAdv.Show(this,
                        "Please enter an appropriate limit.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (limit < NumMembersAttending)
                {

                    MessageBoxAdv.Show(this,
                        $"There are already {NumMembersAttending} members attending.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;


                }

                else
                {
                    string priceWithoutEGP = textBoxPrice.Text.Substring(3);
                    float.TryParse(priceWithoutEGP, out float priceFloat);


                    result = controller.AcademyUpdateSession(sessionID,AcademyID, Description, priceFloat, limit, Duration, Address, Date, Time);
                }
            }
            else
            {

                MessageBoxAdv.Show(this,
                    "Do not leave any fields empty.",
                    "No changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {

                MessageBoxAdv.Show(this,
                    "Session updated successfully",
                    "Profile Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DoneEditing();

                BaseSessionsForm.ShowResults(current_session_index);
                this.Close();

            }
            else
            {
                MessageBox.Show("Error updating session.");
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
