///<summary>
/// Georgian College - Computer Programmer
/// COMP 1004 - Rapid Application Development
/// Instructor: Tom Tsiliopoulos
/// 
/// Assignment 1: Sharp Mail Order – SALES BONUS
/// Description: The Company has instituted a bonus program to give its employees an incentive to sell more.	
/// For every dollar the store makes in	a four-week period, the employees receive 2	percent of sales.The
/// amount of bonus each employee receives is based upon the percentage of hours he or she worked
/// during the bonus period(a total of  160	hours)
/// 
/// Author Name: Pranav Kural
/// Student Number: 200333253
/// 
/// Last modified: January 29, 2017
/// 
/// Brief revision history:
/// Initial commit to add default .gitIgnore and .gitAttribute files.
/// .....
/// Improved the logic for validating the hours worked by giving up use of RegEx
/// Added the logic to validate that total sales is a an integer or a decimal number
/// Gave all Windows Form and all attached UI Controls appropriate Variable names
/// Added logic to represent total sales as currency value and added commenting
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// SharpMailOrder namespace
/// </summary>
namespace SharpMailOrder
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
            // creating the MailOrder form
            Application.Run(new MailOrder());
        }
    }
}
