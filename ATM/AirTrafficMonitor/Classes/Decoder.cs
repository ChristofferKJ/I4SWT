using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Decoder
    {
        public static Plane Decode(List<string> ddata)
        {

            foreach (string fly in ddata)
            {

                string[] split = fly.Split(';');

                string tag = split[0];
                string X_Coord = split[1];
                string Y_Coord = split[2];
                string Alt = split[3];
                string Timestamp = split[4];

                Plane flyet = new Plane(tag, X_Coord, Y_Coord, Alt, Timestamp);

                return flyet;

            }
            return null; 
        }

    }
}

