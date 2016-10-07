namespace SharpMailOrder_SalesBonus
{
    partial class SalesBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonus));
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EnRadioButton = new System.Windows.Forms.RadioButton();
            this.FrRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.GroupBox();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LanguageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(13, 389);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(105, 389);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(197, 389);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EnRadioButton
            // 
            this.EnRadioButton.AutoSize = true;
            this.EnRadioButton.Checked = true;
            this.EnRadioButton.Location = new System.Drawing.Point(6, 19);
            this.EnRadioButton.Name = "EnRadioButton";
            this.EnRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnRadioButton.TabIndex = 1;
            this.EnRadioButton.TabStop = true;
            this.EnRadioButton.Text = "English";
            this.EnRadioButton.UseVisualStyleBackColor = true;
            this.EnRadioButton.CheckedChanged += new System.EventHandler(this.EnRadioButton_CheckedChanged);
            // 
            // FrRadioButton
            // 
            this.FrRadioButton.AutoSize = true;
            this.FrRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FrRadioButton.Name = "FrRadioButton";
            this.FrRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrRadioButton.TabIndex = 2;
            this.FrRadioButton.Text = "Français";
            this.FrRadioButton.UseVisualStyleBackColor = true;
            this.FrRadioButton.CheckedChanged += new System.EventHandler(this.FrRadioButton_CheckedChanged);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(137, 109);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.EmployeeNameTextBox.TabIndex = 3;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(137, 139);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 4;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(137, 169);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 5;
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Location = new System.Drawing.Point(137, 199);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesTextBox.TabIndex = 6;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(137, 229);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(10, 112);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(91, 13);
            this.EmployeeNameLabel.TabIndex = 22;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(28, 142);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(73, 13);
            this.EmployeeIDLabel.TabIndex = 21;
            this.EmployeeIDLabel.Text = "Employee ID :";
            this.EmployeeIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(19, 172);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(82, 13);
            this.HoursWorkedLabel.TabIndex = 20;
            this.HoursWorkedLabel.Text = "Hours Worked :";
            this.HoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(35, 202);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(66, 13);
            this.TotalSalesLabel.TabIndex = 19;
            this.TotalSalesLabel.Text = "Total Sales :";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(29, 232);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(72, 13);
            this.SalesBonusLabel.TabIndex = 18;
            this.SalesBonusLabel.Text = "Sales Bonus :";
            // 
            // LanguageBox
            // 
            this.LanguageBox.Controls.Add(this.EnRadioButton);
            this.LanguageBox.Controls.Add(this.FrRadioButton);
            this.LanguageBox.Location = new System.Drawing.Point(185, 13);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(87, 80);
            this.LanguageBox.TabIndex = 17;
            this.LanguageBox.TabStop = false;
            this.LanguageBox.Text = "Language";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(53, 319);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(59, 13);
            this.DebugLabel.TabIndex = 0;
            this.DebugLabel.Text = "debuglabel";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(13, 418);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(259, 23);
            this.NextButton.TabIndex = 24;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SalesBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 449);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.LanguageBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "SalesBonus";
            this.Text = "Sales Bonus Calculator";
            this.Load += new System.EventHandler(this.SalesBonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LanguageBox.ResumeLayout(false);
            this.LanguageBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RadioButton EnRadioButton;
        private System.Windows.Forms.RadioButton FrRadioButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Button NextButton;
    }
}

