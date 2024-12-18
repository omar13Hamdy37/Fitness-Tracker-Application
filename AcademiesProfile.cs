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
    public partial class AcademiesProfile : Form
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        // Basic Academy info for welcome screen
        int ID;
        string Name, Description, AreaOfExpertise;

        string CertificateTitle, CertificateIssuingBody, CertificateDateOfIssue, CertificateExpirationDate;
        
        public AcademiesProfile(int ID)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            LoadAcademyInfo();
        }

        private void buttonEditCertificate_Click(object sender, EventArgs e)
        {
            textBoxTitle.ReadOnly = false; textBoxIssuingBody.ReadOnly = false; textBoxDateOfIssue.ReadOnly = false;
            textBoxExpirationDate.ReadOnly = false;
            buttonConfirmCertificate.Visible = true;
        }

        private void buttonConfirmCertificate_Click(object sender, EventArgs e)
        {
            // Read data
           CertificateTitle = textBoxTitle.Text; CertificateIssuingBody = textBoxIssuingBody.Text;
           CertificateDateOfIssue = textBoxDateOfIssue.Text; CertificateExpirationDate = textBoxExpirationDate.Text;

            // Check if fields empty
            if (CertificateTitle == "" || CertificateIssuingBody == "" || CertificateDateOfIssue == ""|| CertificateExpirationDate == "")
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update Certificate
            int result = controller.UpdateAcademyCertificate(ID,CertificateTitle,CertificateDateOfIssue,CertificateIssuingBody,CertificateExpirationDate);

            if (result == 1)
            {
                MessageBox.Show("Certificate Updated Successfully.");
                // Return to original state
                buttonConfirmCertificate.Visible = false;

                textBoxTitle.ReadOnly = true; textBoxIssuingBody.ReadOnly = true; textBoxDateOfIssue.ReadOnly = true;
                textBoxExpirationDate.ReadOnly = true;
            }
            else
            { 
                MessageBox.Show("Certificate could not be updated.");
                return;
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false ; textBoxDescription.ReadOnly = false; textBoxAOE.ReadOnly = false ;
            buttonConfirmProfileChanges.Visible = true ;

        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            // Read data
            Name = textBoxName.Text ; Description = textBoxDescription.Text ; AreaOfExpertise = textBoxAOE.Text ;
            // Check if fields empty
            if (Name == "" || Description == ""|| AreaOfExpertise == "")
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update profile
            int result = controller.UpdateBasicAcademyProfile(ID, Name, Description, AreaOfExpertise);

            if (result == 1)
            {
                MessageBox.Show("Profile Updated Successfully.");
                // Return to original state
                buttonConfirmProfileChanges.Visible=false;

                textBoxName.ReadOnly = true ; textBoxDescription.ReadOnly = true ; textBoxAOE.ReadOnly=true;
            }
            else
            {
                MessageBox.Show("Profile could not be updated.");
                return;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AcademiesProfile_Load(object sender, EventArgs e)
        {

        }

        private void LoadAcademyInfo()
        {
            Name = controller.GetAcademyName(ID);
            Description = controller.GetAcademyDescription(ID);
            AreaOfExpertise = controller.GetAcademyAOE(ID);

            CertificateTitle = controller.GetAcademyCertificateTitle(ID);
            CertificateIssuingBody = controller.GetAcademyCertificateIssuingBody(ID);
            CertificateDateOfIssue = controller.GetAcademyCertificateDateOfIssue(ID);
            CertificateExpirationDate = controller.GetAcademyCertificateExpirationDate(ID);

            textBoxName.Text = Name;
            textBoxDescription.Text = Description;
            textBoxAOE.Text = AreaOfExpertise;

            textBoxTitle.Text = CertificateTitle;
            textBoxIssuingBody.Text = CertificateIssuingBody;
            textBoxDateOfIssue.Text = CertificateDateOfIssue;
            textBoxExpirationDate.Text = CertificateExpirationDate;


        }
    }
}
