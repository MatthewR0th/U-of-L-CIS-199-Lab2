//Grading ID: K1791
//Lab 2
//13 September 2020
//CIS 199-02
//A simple GUI application that calculates tip from the price of a meal.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab2());

            
        }
    
    
    
    }
}
