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
/// Trello Board: https://trello.com/b/QV6C4i7V
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Project namespace
/// </summary>
namespace SharpMailOrder
{
    /// <summary>
    /// MailOrder Class containing a form to calculate sales bonus of employees working in a mail order company
    /// </summary>
    public partial class MailOrder : Form
    {
        /// <summary>
        /// True - If the form language is set to English
        /// </summary>
        private bool _isLanguageEnglish;

        /// <summary>
        /// MailOrder Constructor to call the MailOrder InitializeComponent method to setup the form application
        /// </summary>
        public MailOrder()
        {
            InitializeComponent();
            _isLanguageEnglish = true; // language is English by default
        }

        /// <summary>
        /// Handle the click on all the form buttons
        /// </summary>
        /// <param name="sender">Button object passed as an Object type</param>
        /// <param name="e">Button click event arguments</param>
        public void MailOrderButtonClickHandler(object sender, EventArgs e)
        {
            // downcasting the sender object to Button object
            Button MailOrderButton = sender as Button;

            // select the button clicked
            switch (MailOrderButton.Tag.ToString())
            {
                case "calculateButton":

                    // parsing the values of total hours worked and total sales
                    int totalHoursWorked = 0;
                    double totalSales = 0;
                    string totalSalesEntered = totalSalesTextBox.Text.ToString();
                    string totalSalesValue = ((totalSalesEntered.IndexOf('$') != -1) ? totalSalesEntered.Remove(totalSalesEntered.IndexOf('$'), 1) : totalSalesEntered) + ((totalSalesEntered.IndexOf('.') == (totalSalesEntered.Length - 1)) ? "0" : "");

                    // verify the values entered for hours worked and total sales before proceeding
                    if (Int32.TryParse(hoursWorkedTextBox.Text, out totalHoursWorked) && Double.TryParse(totalSalesValue, out totalSales))
                    {
                        // calculating the sales bonus
                        salesBonusTextBox.Text = (((double)totalHoursWorked / 160) * (totalSales * 0.02)).ToString("C", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        DisplayError((_isLanguageEnglish) ? "Invalid value for the total hours worked or total sales field" : "Valeur non valide pour le nombre total d'heures travaillées ou le nombre total de ventes", (_isLanguageEnglish) ? "Invalid Operation" : "Opération invalide");
                        salesBonusTextBox.Text = ""; // clear the value of text box
                    }
                    break;

                case "printButton":

                    // Fake message representing the data being transferred to the printer
                    MessageBox.Show((_isLanguageEnglish) ? "Form results being transferred to the printer." : "Les résultats du formulaire sont transférés à l'imprimante.");
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

        /// <summary>
        /// Handle the Click and key press event on the text boxes
        /// </summary>
        /// <param name="sender">TextBox object passed as an Object type</param>
        /// <param name="e">Arguments related to the event</param>
        public void MailOrderTextBoxHandler(object sender, EventArgs e)
        {
            // casting the object received to a TextBox
            TextBox MailOrderTextBox = sender as TextBox;

            // switch statement to see which TextBox has been selected using the Tag property
            switch (MailOrderTextBox.Tag.ToString())
            {
                case "employeeName":

                    // check is the Employee's Name field contains only Letters and certain other characters, using RegEx
                    if (employeeNameTextBox.Text.Length != 0 && !System.Text.RegularExpressions.Regex.IsMatch(employeeNameTextBox.Text, @"^[\p{L} \.'\-]+$"))
                    {
                        DisplayError((_isLanguageEnglish) ? "Invalid character added for the name field. Please enter a valid name." : "Caractère non valide ajouté pour le champ de nom. Merci d'entrer un nom valide.", (_isLanguageEnglish) ? "Invalid Name" : "Nom incorrect");
                        // remove the invalid character added
                        employeeNameTextBox.Text = employeeNameTextBox.Text.Remove(employeeNameTextBox.Text.Length - 1);
                        // set the caret to the end of textbox
                        employeeNameTextBox.SelectionStart = employeeNameTextBox.Text.Length;
                    }
                    break;
                    
                case "hoursWorked":

                    // check is the hoursWorked field contains only numbers
                    int hoursWorked = 0;
                    if (!Int32.TryParse(hoursWorkedTextBox.Text.ToString(), out hoursWorked) && (hoursWorkedTextBox.Text.Length != 0))
                    {
                        DisplayError((_isLanguageEnglish) ? "Please enter numbers only." : "Veuillez saisir des chiffres uniquement.", (_isLanguageEnglish) ? "Invalid Hours Worked" : "Heures invalides travaillées");
                        // remove the invalid input
                        hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                        // set the caret to the end of textbox
                        hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
                    }
                    else
                    {
                        // to check if current value of hours worked field has exceeded the limit of 160
                        if (hoursWorked < 0 || hoursWorked > 160)
                        {
                            DisplayError((_isLanguageEnglish) ? "Total hours worked cannot be greater than 160 hours." : "Le total des heures travaillées ne peut être supérieur à 160 heures.", (_isLanguageEnglish) ? "Invalid Input" : "entrée invalide");
                            // remove the last input
                            hoursWorkedTextBox.Text = hoursWorkedTextBox.Text.Remove(hoursWorkedTextBox.Text.Length - 1);
                            // set the caret to the end of textbox
                            hoursWorkedTextBox.SelectionStart = hoursWorkedTextBox.Text.Length;
                        }
                    }
                    break;

                case "totalSales":

                    // check is the total sales field contains only numbers (or decimal numbers)
                    double totalSales = 0;
                    string totalSalesEntered = totalSalesTextBox.Text.ToString(); // unformatted (raw) string of text value of the total sales field
                    // removing the formatting from the total sales value like '$' character, and adding a '0' if '.' is the last character with nothing after it
                    string totalSalesValue = ((totalSalesEntered.IndexOf('$') != -1) ? totalSalesEntered.Remove(totalSalesEntered.IndexOf('$'), 1) : totalSalesEntered) + ((totalSalesEntered.IndexOf('.') == (totalSalesEntered.Length - 1)) ? "0" : ""); 
                    if (!Double.TryParse(totalSalesValue, out totalSales) && (totalSalesValue.Length != 0))
                    {
                        DisplayError((_isLanguageEnglish) ? "Please enter numbers only." : "Veuillez saisir des chiffres uniquement.", (_isLanguageEnglish) ? "Invalid Total Sales" : "Ventes totales non valides");
                        // remove the invalid input
                        totalSalesTextBox.Text = "$" + string.Format("{0:0.00}", (totalSalesValue.Length != 0) ? totalSalesValue.Remove(totalSalesValue.Length - 1) : "");
                        // set the caret to the end of textbox
                        totalSalesTextBox.SelectionStart = totalSalesTextBox.Text.Length;
                    }
                    else
                    {
                        // display total sales in currency format after validation passes
                        totalSalesTextBox.Text = "$" + string.Format("{0:0.00}", ((totalSalesValue.Length != 0) ? ((totalSalesValue.IndexOf('.') == (totalSalesValue.Length - 1)) ? totalSalesValue.Remove(totalSalesValue.Length -1, 1) : totalSalesValue) : ""));
                        totalSalesTextBox.SelectionStart = totalSalesTextBox.Text.Length;
                    }
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
            if (FrenchLanguageRadioButton.Checked == true)
            {
                languageSelectorGroupBox.Text = "Langue";
                employeeNameLabel.Text = "Employé Nom:";
                employeeIDLabel.Text = "Employé ID:";
                hoursWorkedLabel.Text = "Heures Travaillées:";
                totalSalesLabel.Text = "Ventes totales:";
                salesBonusLabel.Text = "Bonus de vente:";
                calculateSalesBonusButton.Text = "Calculer";
                printFormResultsButton.Text = "Imprimer";
                clearFormValuesButton.Text = "Effacer";
                _isLanguageEnglish = false; // set the language to French
            }
            else
            {
                // labels for English language
                languageSelectorGroupBox.Text = "Language";
                employeeNameLabel.Text = "Employee Name:";
                employeeIDLabel.Text = "Employee ID:";
                hoursWorkedLabel.Text = "Hours Worked:";
                totalSalesLabel.Text = "Total Sales:";
                salesBonusLabel.Text = "Sales Bonus:";
                calculateSalesBonusButton.Text = "Calculate";
                printFormResultsButton.Text = "Print";
                clearFormValuesButton.Text = "Clear";
                _isLanguageEnglish = true; // set the language to English
            }
        }
        
    }
}
