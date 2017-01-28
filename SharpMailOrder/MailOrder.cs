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
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }


        public void MailOrderButtonClickHandler(object sender, EventArgs e)
        {
            Button MailOrderButton = sender as Button;

            switch (MailOrderButton.Tag.ToString())
            {
                case "calculateButton":

                    // parsing the values of total hours worked and total sales
                    int totalHoursWorked = 0;
                    double totalSales = 0;
                    if (Int32.TryParse(hoursWorkedTextBox.Text, out totalHoursWorked) && Double.TryParse(totalSalesTextBox.Text, out totalSales))
                    {
                        totalHoursWorked = Int32.Parse(hoursWorkedTextBox.Text);
                        totalSales = Double.Parse(totalSalesTextBox.Text);

                        // calculating the sales bonus
                        salesBonusTextBox.Text = (((double)totalHoursWorked / 160) * (totalSales * 0.02)).ToString("C", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        DisplayError("Invalid value for the total hours worked or total sales field", "Invalid Operation");
                        salesBonusTextBox.Text = "0";
                    }
                    break;

                case "printButton":

                    MessageBox.Show("Form results being transferred to the printer.");
                    break;

                case "clearButton":

                    // clear all the text boxes
                    employeeNameTextBox.Text = "";
                    employeeIDTextBox.Text = "";
                    hoursWorkedTextBox.Text = "";
                    salesBonusTextBox.Text = "";
                    break;

            }
        }

        public void MailOrderTextBoxHandler(object sender, EventArgs e)
        {
            // casting the object received to a TextBox
            TextBox MailOrderTextBox = sender as TextBox;

            // switch statement to see which TextBox has been selected using the Tag property
            switch (MailOrderTextBox.Tag.ToString())
            {
                case "employeeName":

                    // check is the Employee's Name field contains only Letters and certain other characters, using RegEx
                    if (!System.Text.RegularExpressions.Regex.IsMatch(employeeNameTextBox.Text, @"^[\p{L} \.'\-]+$"))
                    {
                        DisplayError("Invalid character added for the name field. Please enter a valid name.", "Invalid Name");
                        // remove the invalid character added
                        employeeNameTextBox.Text = employeeNameTextBox.Text.Remove(employeeNameTextBox.Text.Length - 1);
                        // set the caret to the end of textbox
                        employeeNameTextBox.SelectionStart = employeeNameTextBox.Text.Length;
                    }
                    break;
                    
                case "hoursWorked":

                    // check is the hoursWorked field contains only numbers, using RegEx
                    int hoursWorked = 0;
                    if (!Int32.TryParse(hoursWorkedTextBox.Text.ToString(), out hoursWorked) && (hoursWorkedTextBox.Text.Length != 0))
                    {
                        DisplayError("Please enter only numbers.", "Invalid Input");
                        // remove the invalid input
                        hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                        // set the caret to the end of textbox
                        hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
                    }
                    else
                    {
                        // to check if current value of hours worked field has exceeded the limit of 160
                        if (hoursWorked > 160)
                        {
                            DisplayError("Total hours worked cannot be greater than 160 hours.", "Inavild Input");
                            // remove the last input
                            hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                            // set the caret to the end of textbox
                            hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
                        }
                    }
                    break;

                case "totalSales":



                    break;
                default:
                    break;
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

        /// <summary>
        /// Method to switch the form langauge based on radio button selection
        /// </summary>
        /// <param name="sender">Radio button object</param>
        /// <param name="e">Event arguments</param>
        private void switchLanguage(object sender, EventArgs e)
        {
            // if french language is selected
            if (FrenchlanguageRadioButton.Checked == true)
            {
                languageSelectorGroupBox.Text = "Langue";
                employeeNameLabel.Text = "Employé Nom:";
                employeeIDLabel.Text = "Employé ID:";
                hoursWorkedLabel.Text = "Heures Travaillées:";
                totalSalesLabel.Text = "Ventes totales:";
                salesBonusLabel.Text = "Bonus de vente:";
                calculateButton.Text = "Calculer";
                printButton.Text = "Imprimer";
                clearButton.Text = "Effacer";
            }
            else
            {
                languageSelectorGroupBox.Text = "Language";
                employeeNameLabel.Text = "Employee Name:";
                employeeIDLabel.Text = "Employee ID:";
                hoursWorkedLabel.Text = "Hours Worked:";
                totalSalesLabel.Text = "Total Sales:";
                salesBonusLabel.Text = "Sales Bonus:";
                calculateButton.Text = "Calculate";
                printButton.Text = "Print";
                clearButton.Text = "Clear";
            }
        }
    }
}
