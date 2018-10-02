using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Renedition
    {
        public void render(List<Plane> planes)
        {
            foreach (Plane plane in planes)
            {
                Console.WriteLine($"Plane with tag: {plane.Tag} is at the coordinates({plane.XCoordinate},{plane.YCoordinate},{plane.Altitude})");
            }

        }
        public void CurSepEvent(string planeA,string planeB, string TimeStamp)
        {
            Console.WriteLine($"The two planes {planeA} and {planeB} had a separation event at {TimeStamp}");

        }

    }
}
