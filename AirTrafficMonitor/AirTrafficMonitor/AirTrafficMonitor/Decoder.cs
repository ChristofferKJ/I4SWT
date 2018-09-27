using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AirTrafficMonitor
{
    public class Decoder
    {
        static void Decode(List<string> ddata)
        {

            foreach (string fly in ddata)
            {

                string[] split = fly.Split(';');

                string tag = split[0];
                string X_Coord = split[1];
                string Y_Coord = split[2];
                string Alt = split[3];
                string Timestamp = split[4];

                Console.WriteLine(tag + " " + X_Coord + " " + Y_Coord + " " + Alt + " " + Timestamp);

            }
        }

        public static void Main()
        {
            List<string> data = new List<string>();
            string fly1 = "ATR423;39045;12932;14000;20151006213456789";
            string fly2 = "ATR999;40000;12932;14000;20151006213456789";

            data.Add(fly1);
            data.Add(fly2);

            Decode(data);
        }
    }
}

