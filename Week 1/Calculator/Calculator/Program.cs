using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static void Main()
        {
            Methods.Calculator tak = new Methods.Calculator();

            Console.WriteLine(tak.Add(5,6)); 
            Console.WriteLine(tak.Subtract(6,2));
            Console.WriteLine(tak.Multiply(5,5));
            Console.WriteLine(tak.Power(5,5));

        }

    
    }
}
