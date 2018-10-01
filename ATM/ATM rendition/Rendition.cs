using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Rendition
    {
        static void Main()
        {

            List<string> data = new List<string>();
 
            string fly1 = "ATR423;39045;12932;14000;20151006213456789";
            string fly2 = "ATR999;40000;12932;14000;20151006213456789";

            data.Add(fly1);
            data.Add(fly2);


            Plane plane1 = new Plane("ATR423", "1000", "1000", "5000", "20180928000000000");
            Plane plane2 = new Plane("ATR423", "2000", "2000", "4000", "20180928000001000");

            
            Console.WriteLine($"Velocity in m/s: {plane1.CalcVelocity(plane1, plane2)}");

            Console.WriteLine(Decoder.Decode(data).Tag, Decoder.Decode(data).TimeStamp);

           

        }
    }
}
