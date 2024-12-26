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
namespace FitnessApplication
{
    public partial class AcademiesHome : RibbonForm
    {
        public AcademiesHome()
        {
            InitializeComponent();
        }

        private void AcademiesHome_Load(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2016;
        }
    }
}
