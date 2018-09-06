using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b; 
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            if (exp == 0.0)
            { throw new Exception("exponent cant be zero thanks."); } // Throw exception feature

            else
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (dividend == 0.0 || divisor == 0.0) // Throw exception feature
            { throw new DivideByZeroException(); } 
            
            else 
            return dividend / divisor;
        }
        
    }
}