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

namespace FitnessApplication
{
    public partial class AcademiesPostSession : SfForm
    {
        Controller controller;
        // Data of user
        string Username; int ID;
        // Data of form
        string Description, Address, Date, Time, Duration;
        int limit; float priceFloat;

        public AcademiesPostSession(string Username, int ID)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.Username = Username;

            DatePickers.MinDateTime = DateTime.Today;

            DurationPicker.Value = DurationPicker.MinDate;
            TimePicker.Value = DateTime.Now;
            DatePickers.Value = DateTime.Now;
        }

        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFree.Checked == true)
            {
                textBoxPrice.Text = string.Empty;
            }
        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            string priceString = textBoxPrice.Text.Substring(3);
            if (float.TryParse(priceString, out priceFloat))
            {
                if (priceFloat > 0) { checkBoxFree.Checked = false; }
            }
            else
            {
                textBoxPrice.Text = "";
            }
        }

        private void buttonPostSession_Click_1(object sender, EventArgs e)
        {
            int result;
            if (ReadSessionDetails())
            {
                if (limit <= 0)
                {
                    MessageBox.Show("Please enter an appropriate limit.");
                    return;
                }

                else
                {
                    result = controller.AcademyInsertSession(Description, priceFloat, limit, Duration, Address, Date, Time, ID);
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any field empty.");
                return;
            }

            if (result == 1)
            {
                MessageBox.Show("Session posted successfully.");
                ResetSessionDetails();
            }
            else
            {
                MessageBox.Show("Error posting session.");
            }
        }

        private bool ReadSessionDetails()
        {
            Description = textBoxDescription.Text;
            Address = textBoxAddress.Text;
            limit = (int) numericUpDownLimit.Value;
            // priceFloat already stored

            Date = DatePickers.DateTimeText;
            Time = TimePicker.Text;
            Duration = DurationPicker.Text;
            if(Description == "" || Address == "" || Date == "" || Time == "" || Duration == "" || (textBoxPrice.Text == "" && checkBoxFree.Checked == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ResetSessionDetails()
        {
            textBoxAddress.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            numericUpDownLimit.Value = numericUpDownLimit.Minimum;
            textBoxPrice.Text = string.Empty;
            checkBoxFree.Checked = false;

            DurationPicker.Value = DurationPicker.MinDate;

            TimePicker.Value = DateTime.Now;
            DatePickers.Value = DateTime.Now;


        }




        private void AcademiesPostSession_Load(object sender, EventArgs e)
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


    }

}
