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

           


            Console.WriteLine(Decoder.Decode(data).Tag, Decoder.Decode(data).TimeStamp);

           

        }
    }
}
