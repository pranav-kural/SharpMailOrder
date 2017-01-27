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
                // clear all the text boxes
                case "clearButton":
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

    }
}
