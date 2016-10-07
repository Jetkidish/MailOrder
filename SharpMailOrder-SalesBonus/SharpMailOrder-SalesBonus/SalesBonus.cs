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

namespace SharpMailOrder_SalesBonus
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
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

            CalculateTotal();
            if (EmployeeNameTextBox.Text == "")
            {
                MessageBox.Show("Please Fill In Name/ID");
                ResetTextBox();
                //currently this will throw a huge error
            }
            EmployeeName = Convert.ToString(EmployeeNameTextBox.Text);
            EmployeeID = Convert.ToDouble(EmployeeIDTextBox.Text);
            DebugLabel.Text = EmployeeName + EmployeeID; 
        }

        /// <summary>
        /// 
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
                    MessageBox.Show("Hours Must Be Between 1 and 160!");
                    ResetTextBox();
                }
                TotalSales = Convert.ToDouble(TotalSalesTextBox.Text);
                if (TotalSales <= 0)
                {
                    MessageBox.Show("Total Sales Must Be A Positive Number!!!");
                    ResetTextBox();
                }
                SalesBonus = (HoursWorked / 160) * (TotalSales * 0.02);
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetTextBox();
            }
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Sent To Printer.");
            //this will eventually print the information
        }
        /// <summary>
        /// ClearButton Event Handler
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void SalesBonus_Load(object sender, EventArgs e)
        {

        }
        private void ResetTextBox()
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            EmployeeNameTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            TotalSalesTextBox.Text = "0";
            SalesBonusTextBox.Text = "0";
            //HoursWorkedTextBox.SelectAll();
        }

        private void EnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //DebugLabel.Text = "ENGLISH";
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

        private void FrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //DebugLabel.Text = "FRENCH";
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            EmployeeNameTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            //TotalSalesTextBox.Text = "0";
            SalesBonusTextBox.Text = "0";
        }
    }
}
