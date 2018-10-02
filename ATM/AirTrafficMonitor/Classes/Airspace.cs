using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Airspace
    {
        public List<Plane> Planes { get; set; }

        public Airspace()
        {
            const int SouthWest_Y = 10000;
            const int SouthWest_X = 10000;
            const int NorthEast_Y = 90000;
            const int NorthEast_X = 90000;
            const int MaxHeight = 20000;
            const int MinHeight = 500;
        }


    }
}
