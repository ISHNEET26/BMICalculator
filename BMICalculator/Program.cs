using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    static class Program
    {/// <summary>
    /// Author Name : Ishneet Kaur
    /// Student number - 301045264
    /// Last date modified : 26 th July , 2019
    /// Revision History : 
    /// Add Project Files : 23th July 2019
    /// Basic Interface Created : 24th July 2019
    /// Program Structure Created : 24th July 2019
    /// Splash Screen Added : 24 th July 2019
    /// 
    /// Description of the program : The program calculates the Body Mass Index of an individual by taking inputs like height and weight of the person.
    ///  A person can input his details in metric and imperial units.
    /// </summary>
        public static Dictionary<FormNames, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.WELCOME_SCREEN, new WelcomeScreen());
            Forms.Add(FormNames.BMI_FORM, new BMICalculator());
            Application.Run(new WelcomeScreen());
        }
    }
}
