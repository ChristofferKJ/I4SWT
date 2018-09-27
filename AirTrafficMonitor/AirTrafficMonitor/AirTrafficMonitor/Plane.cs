using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    class Plane
    {
        public string Tag { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int  Altitude { get; set; }
        public string TimeStamp { get; set; }
        public int Velocity { get; set; }
        public int Course { get; set; }

        public List<Plane> Planes;

        Plane(string tag, string x, string y, string altitude, string timeStamp )
        {
            Tag = tag;
            XCoordinate = int.Parse(x);
            YCoordinate = int.Parse(y);
            Altitude = int.Parse(altitude);
            TimeStamp = timeStamp;
            AddPlane(this);


        }

        public void AddPlane(Plane plane)
        {
            foreach (var item in Planes)
            {
                if(plane.Tag == item.Tag)
                {
                    
                }
            }
        }

        public int CalcVelocity(Plane oldPlane, Plane newPlane)
        {
            double XYDiff = Math.Sqrt((Math.Pow((newPlane.XCoordinate - oldPlane.XCoordinate),2) + Math.Pow((newPlane.YCoordinate - oldPlane.YCoordinate),2)));
            double AltitudeDiff = oldPlane.Altitude - newPlane.Altitude;
            double DistanceMoved = Math.Sqrt((Math.Pow(XYDiff,2) + Math.Pow(AltitudeDiff,2)));



        }
    }
}
