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
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double height = Double.Parse(MyHeightTextBox.Text);
            double weight = Double.Parse(MyWeightTextBox.Text);
            double bmi = 0.0;
            if ((height <= 0) || (weight <= 0))
            {
                MessageBox.Show("please insert valid values");
            }
            else if (ImperialRadioButton.Checked)
            {
                bmi = (weight * 703) / (height * height);
            }
            else if (MetricRadioButton.Checked)
            {
                bmi = weight / (height * height);
            }


            if (bmi < 18.5)
            {
                ResultTextBox.Text = "bmi =" + $"{bmi:f2}\n" + "Underweight";
            }

            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                ResultTextBox.Text = "bmi =" + $"{bmi:f2}\n" + "Normal";
            }

           else if (bmi >= 25 && bmi <= 29.9)
            {
                ResultTextBox.Text = "bmi =" + $"{bmi:f2}\n" +"OverWeight";
            }

            else if (bmi >= 30)
            {
                ResultTextBox.Text = "bmi =" + $"{bmi:f2}\n" + " Obese";
            }
        }
    }
}
