using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double sum = a - b;
            return sum; 
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum; 
        }

        public double Power(double x, double exp)
        {
            double sum = Math.Pow(x, exp);
            return sum; 
        }
    }
}
