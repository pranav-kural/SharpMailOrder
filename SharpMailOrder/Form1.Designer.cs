namespace SharpMailOrder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Français = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeID = new System.Windows.Forms.TextBox();
            this.hoursWorked = new System.Windows.Forms.TextBox();
            this.totalSales = new System.Windows.Forms.TextBox();
            this.salesBonus = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Français);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(165, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Languages";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.radioButton1.Location = new System.Drawing.Point(16, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Français
            // 
            this.Français.AutoSize = true;
            this.Français.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.Français.Location = new System.Drawing.Point(16, 53);
            this.Français.Name = "Français";
            this.Français.Size = new System.Drawing.Size(83, 22);
            this.Français.TabIndex = 1;
            this.Français.Text = "Français";
            this.Français.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(38, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee\'s ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.Location = new System.Drawing.Point(35, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours Worked:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label4.Location = new System.Drawing.Point(59, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Sales:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.Location = new System.Drawing.Point(49, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sales Bonus:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(151, 164);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(205, 20);
            this.employeeName.TabIndex = 7;
            this.employeeName.TextChanged += new System.EventHandler(this.employeeName_TextChanged);
            // 
            // employeeID
            // 
            this.employeeID.Location = new System.Drawing.Point(152, 197);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(149, 20);
            this.employeeID.TabIndex = 8;
            this.employeeID.TextChanged += new System.EventHandler(this.employeeID_TextChanged);
            // 
            // hoursWorked
            // 
            this.hoursWorked.Location = new System.Drawing.Point(151, 230);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(149, 20);
            this.hoursWorked.TabIndex = 9;
            this.hoursWorked.TextChanged += new System.EventHandler(this.hoursWorked_TextChanged);
            // 
            // totalSales
            // 
            this.totalSales.Location = new System.Drawing.Point(151, 258);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(149, 20);
            this.totalSales.TabIndex = 10;
            this.totalSales.TextChanged += new System.EventHandler(this.totalSales_TextChanged);
            // 
            // salesBonus
            // 
            this.salesBonus.Location = new System.Drawing.Point(151, 285);
            this.salesBonus.Name = "salesBonus";
            this.salesBonus.ReadOnly = true;
            this.salesBonus.Size = new System.Drawing.Size(149, 20);
            this.salesBonus.TabIndex = 11;
            this.salesBonus.TextChanged += new System.EventHandler(this.salesBonus_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.clearButton.Location = new System.Drawing.Point(277, 320);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 35);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.printButton.Location = new System.Drawing.Point(152, 320);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 35);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.calculateButton.Location = new System.Drawing.Point(16, 320);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 35);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 367);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salesBonus);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Français;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.TextBox employeeID;
        private System.Windows.Forms.TextBox hoursWorked;
        private System.Windows.Forms.TextBox totalSales;
        private System.Windows.Forms.TextBox salesBonus;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

