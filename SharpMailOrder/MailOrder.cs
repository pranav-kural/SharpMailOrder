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
                    salesBonusTextBox.Text = CalculateSalesBonus().ToString();
                    break;
                case "clearButton":
                    // clear all the text boxes
                    employeeNameTextBox.Text = "";
                    employeeIDTextBox.Text = "";
                    hoursWorkedTextBox.Text = "";
                    totalSalesTextBox.Text = "";
                    salesBonusTextBox.Text = "";
                    break;
            }

            salesBonusTextBox.Text += employeeNameTextBox.Text;
        }

        public void MailOrderTextBoxHandler(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

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

    }
}
