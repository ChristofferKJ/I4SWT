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
        public const int SouthWest_Y = 10000;
        public const int SouthWest_X = 10000;
        public const int NorthEast_Y = 90000;
        public const int NorthEast_X = 90000;
        public const int MaxHeight = 20000;
        public const int MinHeight = 500;

        public Airspace()
        {
        }

        public void Checkairspace(Airspace airspace)
        {
            foreach (var plane in Planes)
            {
                if (plane.XCoordinate < SouthWest_X || plane.XCoordinate < SouthWest_Y || plane.YCoordinate > NorthEast_X || plane.YCoordinate >NorthEast_Y || plane.Altitude < MinHeight || plane.Altitude > MaxHeight)
                {
                    Planes.Remove(plane);
                }
            }
        }

    }
}
