using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T num1, T num2);

    internal class CalculatorClass
    {
        public Formula<double> delegateFormula;

        public double GetSum(double a, double b) {
            
            return a + b;
        }
        public double GetDifference(double a, double b)
        {
            return a - b;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetQuotient(double a, double b)
        {
            return a / b;
        }
        public event Formula<double> CalculateEvent
        {
            add {
                Console.WriteLine("Added to the delegate.");
                delegateFormula += value;
            }
            remove {
                Console.WriteLine("Removed to the delegate.");
                delegateFormula -= value;
            }
        }


    }
}
