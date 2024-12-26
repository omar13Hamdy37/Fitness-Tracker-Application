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
    public partial class AcademySessions : SfForm
    {
        DataTable Sessions;
        public AcademySessions(string Username, int ID, DataTable Sessions)
        {
            InitializeComponent();
            this.Sessions = Sessions;

            // Buttons



            Load_Session(0);

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


        private void Load_Session(int index)
        {
 

        }
        private void flowLayoutPanelSessions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadTheSessions()
        {

        }

        private void sfButtonNextSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
