using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            

            double result = 0;
            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    result = cal.GetSum(num1, num2);
                    lblDisplayTotal.Text = result.ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    result = cal.GetDifference(num1, num2);
                    lblDisplayTotal.Text = result.ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    result = cal.GetProduct(num1, num2);
                    lblDisplayTotal.Text = result.ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    result = cal.GetQuotient(num1, num2);
                    lblDisplayTotal.Text = result.ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
            }

        }

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }
    }
}
