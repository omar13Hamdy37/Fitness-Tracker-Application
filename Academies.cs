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

namespace FitnessApplication
{
    public partial class Academies : Form
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        // Basic Academy info for welcome screen
        int ID;
        string Name;

        public Academies()
        {
            InitializeComponent();
            // Initializing controller
            controller = new Controller();
            LoadAcademyInfo();

        }
        private void LoadAcademyInfo()
        {
            ID = 1;
            Name = controller.GetAcademyName(ID);
            labelWelcomeAcademy.Text = $"Welcome, {Name}";

        }
        private void Academies_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            ProfileForm = new AcademiesProfile(ID);
            ProfileForm.Show();

        }
    }
}
