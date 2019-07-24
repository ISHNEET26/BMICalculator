using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    static class Program
    {
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
