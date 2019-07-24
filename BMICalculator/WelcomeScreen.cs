using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            WelcomeScreenTimer.Enabled = true;
        }

        private void WelcomeScreenTimer_Tick(object sender, EventArgs e)
        {
            WelcomeScreenTimer.Enabled = false;
            Program.Forms[FormNames.BMI_FORM].Show();
            this.Hide();
        }
    }
}
