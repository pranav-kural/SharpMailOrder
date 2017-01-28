namespace SharpMailOrder
{
    partial class MailOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.languageSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchlanguageRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishLanguageRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.salesBonusLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.salesBonusTextBox = new System.Windows.Forms.TextBox();
            this.clearFormValuesButton = new System.Windows.Forms.Button();
            this.printFormResultsButton = new System.Windows.Forms.Button();
            this.calculateSalesBonusButton = new System.Windows.Forms.Button();
            this.languageSelectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // languageSelectorGroupBox
            // 
            this.languageSelectorGroupBox.Controls.Add(this.FrenchlanguageRadioButton);
            this.languageSelectorGroupBox.Controls.Add(this.EnglishLanguageRadioButton);
            this.languageSelectorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.languageSelectorGroupBox.Location = new System.Drawing.Point(181, 32);
            this.languageSelectorGroupBox.Name = "languageSelectorGroupBox";
            this.languageSelectorGroupBox.Size = new System.Drawing.Size(150, 89);
            this.languageSelectorGroupBox.TabIndex = 0;
            this.languageSelectorGroupBox.TabStop = false;
            this.languageSelectorGroupBox.Text = "Languages";
            // 
            // FrenchlanguageRadioButton
            // 
            this.FrenchlanguageRadioButton.AutoSize = true;
            this.FrenchlanguageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.FrenchlanguageRadioButton.Location = new System.Drawing.Point(16, 53);
            this.FrenchlanguageRadioButton.Name = "FrenchlanguageRadioButton";
            this.FrenchlanguageRadioButton.Size = new System.Drawing.Size(83, 22);
            this.FrenchlanguageRadioButton.TabIndex = 1;
            this.FrenchlanguageRadioButton.Text = "Français";
            this.FrenchlanguageRadioButton.UseVisualStyleBackColor = true;
            this.FrenchlanguageRadioButton.CheckedChanged += new System.EventHandler(this.switchLanguage);
            this.FrenchlanguageRadioButton.Click += new System.EventHandler(this.switchLanguage);
            // 
            // EnglishLanguageRadioButton
            // 
            this.EnglishLanguageRadioButton.AutoSize = true;
            this.EnglishLanguageRadioButton.Checked = true;
            this.EnglishLanguageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.EnglishLanguageRadioButton.Location = new System.Drawing.Point(16, 29);
            this.EnglishLanguageRadioButton.Name = "EnglishLanguageRadioButton";
            this.EnglishLanguageRadioButton.Size = new System.Drawing.Size(74, 22);
            this.EnglishLanguageRadioButton.TabIndex = 0;
            this.EnglishLanguageRadioButton.TabStop = true;
            this.EnglishLanguageRadioButton.Text = "English";
            this.EnglishLanguageRadioButton.UseVisualStyleBackColor = true;
            this.EnglishLanguageRadioButton.CheckedChanged += new System.EventHandler(this.switchLanguage);
            this.EnglishLanguageRadioButton.Click += new System.EventHandler(this.switchLanguage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.employeeNameLabel.Location = new System.Drawing.Point(12, 164);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.employeeNameLabel.Size = new System.Drawing.Size(133, 18);
            this.employeeNameLabel.TabIndex = 2;
            this.employeeNameLabel.Text = "Employee\'s Name:";
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.employeeIDLabel.Location = new System.Drawing.Point(12, 199);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.employeeIDLabel.Size = new System.Drawing.Size(134, 18);
            this.employeeIDLabel.TabIndex = 3;
            this.employeeIDLabel.Text = "Employee\'s ID:";
            this.employeeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.hoursWorkedLabel.Location = new System.Drawing.Point(12, 230);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hoursWorkedLabel.Size = new System.Drawing.Size(133, 18);
            this.hoursWorkedLabel.TabIndex = 4;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            this.hoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.totalSalesLabel.Location = new System.Drawing.Point(12, 258);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalSalesLabel.Size = new System.Drawing.Size(133, 18);
            this.totalSalesLabel.TabIndex = 5;
            this.totalSalesLabel.Text = "Total Sales:";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesBonusLabel
            // 
            this.salesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonusLabel.Location = new System.Drawing.Point(12, 284);
            this.salesBonusLabel.Name = "salesBonusLabel";
            this.salesBonusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salesBonusLabel.Size = new System.Drawing.Size(133, 18);
            this.salesBonusLabel.TabIndex = 6;
            this.salesBonusLabel.Text = "Sales Bonus:";
            this.salesBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(151, 164);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.employeeNameTextBox.TabIndex = 7;
            this.employeeNameTextBox.Tag = "employeeName";
            this.employeeNameTextBox.TextChanged += new System.EventHandler(this.MailOrderTextBoxHandler);
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(152, 197);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(149, 20);
            this.employeeIDTextBox.TabIndex = 8;
            this.employeeIDTextBox.Tag = "employeeID";
            this.employeeIDTextBox.TextChanged += new System.EventHandler(this.MailOrderTextBoxHandler);
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(151, 230);
            this.hoursWorkedTextBox.MaxLength = 3;
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(149, 20);
            this.hoursWorkedTextBox.TabIndex = 9;
            this.hoursWorkedTextBox.Tag = "hoursWorked";
            this.hoursWorkedTextBox.TextChanged += new System.EventHandler(this.MailOrderTextBoxHandler);
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.Location = new System.Drawing.Point(151, 258);
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.Size = new System.Drawing.Size(149, 20);
            this.totalSalesTextBox.TabIndex = 10;
            this.totalSalesTextBox.Tag = "totalSales";
            this.totalSalesTextBox.TextChanged += new System.EventHandler(this.MailOrderTextBoxHandler);
            // 
            // salesBonusTextBox
            // 
            this.salesBonusTextBox.Location = new System.Drawing.Point(151, 285);
            this.salesBonusTextBox.Name = "salesBonusTextBox";
            this.salesBonusTextBox.ReadOnly = true;
            this.salesBonusTextBox.Size = new System.Drawing.Size(149, 20);
            this.salesBonusTextBox.TabIndex = 11;
            this.salesBonusTextBox.Tag = "salesBonus";
            this.salesBonusTextBox.TextChanged += new System.EventHandler(this.MailOrderTextBoxHandler);
            // 
            // clearFormValuesButton
            // 
            this.clearFormValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.clearFormValuesButton.Location = new System.Drawing.Point(251, 320);
            this.clearFormValuesButton.Name = "clearFormValuesButton";
            this.clearFormValuesButton.Size = new System.Drawing.Size(80, 35);
            this.clearFormValuesButton.TabIndex = 17;
            this.clearFormValuesButton.Tag = "clearButton";
            this.clearFormValuesButton.Text = "Clear";
            this.clearFormValuesButton.UseVisualStyleBackColor = true;
            this.clearFormValuesButton.Click += new System.EventHandler(this.MailOrderButtonClickHandler);
            // 
            // printFormResultsButton
            // 
            this.printFormResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.printFormResultsButton.Location = new System.Drawing.Point(135, 320);
            this.printFormResultsButton.Name = "printFormResultsButton";
            this.printFormResultsButton.Size = new System.Drawing.Size(80, 35);
            this.printFormResultsButton.TabIndex = 16;
            this.printFormResultsButton.Tag = "printButton";
            this.printFormResultsButton.Text = "Print";
            this.printFormResultsButton.UseVisualStyleBackColor = true;
            this.printFormResultsButton.Click += new System.EventHandler(this.MailOrderButtonClickHandler);
            // 
            // calculateSalesBonusButton
            // 
            this.calculateSalesBonusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.calculateSalesBonusButton.Location = new System.Drawing.Point(15, 320);
            this.calculateSalesBonusButton.Name = "calculateSalesBonusButton";
            this.calculateSalesBonusButton.Size = new System.Drawing.Size(80, 35);
            this.calculateSalesBonusButton.TabIndex = 15;
            this.calculateSalesBonusButton.Tag = "calculateButton";
            this.calculateSalesBonusButton.Text = "Calculate";
            this.calculateSalesBonusButton.UseVisualStyleBackColor = true;
            this.calculateSalesBonusButton.Click += new System.EventHandler(this.MailOrderButtonClickHandler);
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 367);
            this.Controls.Add(this.clearFormValuesButton);
            this.Controls.Add(this.printFormResultsButton);
            this.Controls.Add(this.calculateSalesBonusButton);
            this.Controls.Add(this.salesBonusTextBox);
            this.Controls.Add(this.totalSalesTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.salesBonusLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.languageSelectorGroupBox);
            this.Name = "MailOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.languageSelectorGroupBox.ResumeLayout(false);
            this.languageSelectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox languageSelectorGroupBox;
        private System.Windows.Forms.RadioButton FrenchlanguageRadioButton;
        private System.Windows.Forms.RadioButton EnglishLanguageRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label salesBonusLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        private System.Windows.Forms.TextBox salesBonusTextBox;
        private System.Windows.Forms.Button clearFormValuesButton;
        private System.Windows.Forms.Button printFormResultsButton;
        private System.Windows.Forms.Button calculateSalesBonusButton;
    }
}

