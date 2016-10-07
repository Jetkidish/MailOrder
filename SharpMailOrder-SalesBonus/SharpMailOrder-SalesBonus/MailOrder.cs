using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * So, I'm not sure if this counts as a program header, but here goes...
 * Sales Bonus Calculator - Designed by Devon Cochane (SN 200244662)
 * Last modified 2016-10-07 @ 6:39pm
 * Rev 3.1
 * This program will take given sales and employee information and output an appropriate bonus based on hours worked and total sales
*/


namespace SharpMailOrder_SalesBonus
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CalculateButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string EmployeeName;
            double EmployeeID;
            double HoursWorked;

            CalculateTotal();
            if (EmployeeNameTextBox.Text == "")
            {
                MessageBox.Show("Please Fill In Name/ID");
                ResetFields();
             
                //currently this will throw a huge error when the employee name is left blank
            }
            if (EmployeeNameTextBox.Text == "Tom")
            {
                MessageBox.Show("Hey Tom!!");
            }
            EmployeeName = Convert.ToString(EmployeeNameTextBox.Text);
            EmployeeID = Convert.ToDouble(EmployeeIDTextBox.Text);
            HoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
            OutputLabel.Text = EmployeeName + ", ID # " + EmployeeID + " worked " + HoursWorked + " hours."; 
        }
        /// <summary>
        /// TotalSalesTextBox KeyPress Event Handler
        /// This makes it so you can ONLY USE NUMBERS in the SALES TEXT BOX
        /// This was taken from the following youtube video: https://www.youtube.com/watch?v=CLzltMQNENw created by Anam Khoirul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalSalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; //8 is the backspace key
        }
        /// <summary>
        /// HoursWorkedTextBox KeyPress Event Handler
        /// This makes it so you can ONLY USE NUMBERS in the HOURS WORKED TEXT BOX
        /// This was taken from the following youtube video: https://www.youtube.com/watch?v=CLzltMQNENw created by Anam Khoirul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoursWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; //8 is the backspace key
        }
        /// <summary>
        /// This method calculates the sales bonus for each employee by dividing the total hours worked by 160, 
        /// then multiplying that by the total sales multiplied by two
        /// It will also yell at you if you enter dumb info
        /// </summary>
        private void CalculateTotal()
        {
            // Local Variables
            double HoursWorked;
            double TotalSales;
            double SalesBonus;

            try
            {
                HoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
                if (HoursWorked >= 161 || HoursWorked <=0)
                {
                    //input validation
                    MessageBox.Show("Hours Must Be Between 1 and 160!");
                    ResetFields();
                }
                TotalSales = Convert.ToDouble(TotalSalesTextBox.Text);
                if (TotalSales <= 0)
                {
                    //input validation
                    MessageBox.Show("Total Sales Must Be A Positive Number!!!");
                    ResetFields();
                }
                SalesBonus = (HoursWorked / 160) * (TotalSales * 0.02);
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                //this is shown if the user manages to put in crap data
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetFields();
            }
        }
        /// <summary>
        /// Print Button Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Sent To Printer.");
            //this will eventually print the information
        }
        /// <summary>
        /// ClearButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void SalesBonus_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method does a total reset of all text boxes
        /// </summary>
        private void ResetTextBox()
        {

            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            EmployeeNameTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            TotalSalesTextBox.Text = "0";
            SalesBonusTextBox.Text = "0";
            OutputLabel.Text = "";
            //HoursWorkedTextBox.SelectAll();
        }
        /// <summary>
        /// This method does a semi rest, but DOES NOT touch the Total Sales text box
        /// </summary>
        private void ResetFields()
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            EmployeeNameTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            SalesBonusTextBox.Text = "0";
            OutputLabel.Text = "";
        }
        /// <summary>
        /// EnRadioButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //this changes all the labels and buttons to English
            LanguageBox.Text = "Language";
            EmployeeNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID :";
            HoursWorkedLabel.Text = "Hours Worked :";
            TotalSalesLabel.Text = "Total Sales :";
            SalesBonusLabel.Text = "Sales Bonus :";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            ClearButton.Text = "Clear";
        }
        /// <summary>
        /// FrRadioButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //This changes all the labels and buttons to french
            LanguageBox.Text = "La Langue";
            EmployeeNameLabel.Text = "Le nom de l'employé";
            EmployeeIDLabel.Text = "ID employé :";
            HoursWorkedLabel.Text = "Les heures travaillées :";
            TotalSalesLabel.Text = "Total des ventes :";
            SalesBonusLabel.Text = "Bonus de vente :";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            ClearButton.Text = "Effacer";

        }
        /// <summary>
        /// NextButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

    }
}
