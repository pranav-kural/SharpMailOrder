
/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMailOrder
{
    public partial class MailOrderModularised : Form
    {
        public MailOrderModularised()
        {
            //InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MailOrderButtonClickHandler(object sender, EventArgs e)
        {
            Button MailOrderButton = sender as Button;

            switch (MailOrderButton.Tag.ToString())
            {
                case "calculateButton": salesBonusTextBox.Text = CalculateSalesBonus().ToString("C", System.Globalization.CultureInfo.CurrentCulture);
                    break;
                case "clearButton": ClearAllTextBoxes();
                    break;
            }

            salesBonusTextBox.Text += employeeNameTextBox.Text;
        }

        public void MailOrderTextBoxHandler(object sender, EventArgs e)
        {
            TextBox MailOrderTextBox = sender as TextBox;

            switch (MailOrderTextBox.Tag.ToString())
            {
                case "employeeName":
                    break;
                case "employeeID":
                    break;
                case "hoursWorked": VerifyHoursWorked();
                    break;
                case "totalSales":
                    break;
                default:
                    break;
            }

        }

        private double CalculateSalesBonus()
        {
            // parsing the values of total hours worked and total sales
            int totalHoursWorked = 0;
            double totalSales = 0;
            if (Int32.TryParse(hoursWorkedTextBox.Text, out totalHoursWorked) && Double.TryParse(totalSalesTextBox.Text, out totalSales))
            {
                totalHoursWorked = Int32.Parse(hoursWorkedTextBox.Text);
                totalSales = Double.Parse(totalSalesTextBox.Text);

                // calculating the sales bonus
                return (((double)totalHoursWorked / 160) * (totalSales * 0.02));
            }
            else
            {
                MessageBox.Show("Error: Invalid value for the total hours worked  or total sales field");
                return 0;
            }

        }

        /// <summary>
        /// Clear all text boxes
        /// </summary>
        private void ClearAllTextBoxes()
        {
            // clear all the text boxes
            employeeNameTextBox.Text = "";
            employeeIDTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            totalSalesTextBox.Text = "";
            salesBonusTextBox.Text = "";
        }

        private void VerifyHoursWorked()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(hoursWorkedTextBox.Text, "[^0-9]"))
            {
                DisplayError("Please enter only numbers.", "Invalid Input");
                // remove the invalid input
                hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                // set the caret to the end of textbox
                hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
            }
            else
            {
                if ((Int16.Parse(hoursWorkedTextBox.Text.ToString())) > 160)
                {
                    DisplayError("Total hours worked cannot be greater than 160 hours.", "Inavild Input");
                    // remove the last input
                    hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                    // set the caret to the end of textbox
                    hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
                }
            }
        }

        /// <summary>
        /// Method to handle displaying of the errors using MessageBox
        /// </summary>
        /// <param name="message">Despcriptive error message</param>
        /// <param name="title">Title for the MessageBox displaying error</param>
        private void DisplayError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
*/