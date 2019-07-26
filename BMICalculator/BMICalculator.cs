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
    {/// <summary>
     ///  /// Author Name : Ishneet Kaur
     /// Student number : 301045264
     /// Last date modified : 26 th July , 2019
     /// Revision History : 
     /// Add Project Files          : 23th July, 2019
     /// Basic Interface Created    : 24th, July 2019
     /// Program Structure Created  : 24th, July 2019
     /// Splash Screen Added        : 24th July, 2019
     /// Project Description Added  : 26th, July 2019
     /// 
     /// Description of the program : The program calculates the Body Mass Index of an individual by taking inputs like height and weight of the person.
     ///  A person can input his details in metric and imperial units.
     /// </summary>
        public BMICalculator()
        { ///<summary>
          /// Functionality : It initializes the components.
          /// Scope: Public
          /// 
          ///</summary>
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
           ///<summary>
           /// Functionality : This is the solution structure.
           /// Scope: Private
           /// Click event for calculating the BMI and displaying the result.
           ///</summary>


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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ///<summary>
            /// Functionality : Reset button click event resets the screen to its original state.
            /// Scope: Private
            /// 
            ///</summary>
            ResultTextBox.Text = " ";
            MyHeightTextBox.Text = " ";
            MyWeightTextBox.Text = " ";
            ImperialRadioButton.Checked = false;
            MetricRadioButton.Checked = false;
        }
    }
}
