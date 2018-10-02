using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Plane
    {
        public string Tag { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int  Altitude { get; set; }
        public string TimeStamp { get; set; }
        public double Velocity { get; set; }
        public int Course { get; set; }

        public List<Plane> Planes;

        public Plane(string tag, string x, string y, string altitude, string timeStamp )
        {
            Tag = tag;
            XCoordinate = int.Parse(x);
            YCoordinate = int.Parse(y);
            Altitude = int.Parse(altitude);
            TimeStamp = timeStamp;
           // AddPlane(this);


        }

        public void AddPlane(Plane plane)
        {
            foreach (var item in Planes)
            {
                if(plane.Tag == item.Tag)
                {
                    Console.WriteLine("Updating old plane");
                    item.Velocity = CalcVelocity(item, plane);
                    item.Altitude = plane.Altitude;
                    item.XCoordinate = plane.XCoordinate;
                    item.YCoordinate = plane.YCoordinate;
                    item.TimeStamp = plane.TimeStamp;
                    item.Course = // add CalcCourse func

                }
                else
                {
                    Console.WriteLine("Adding new plane");
                    Planes.Add(plane);
                }
            }
        }

        public double CalcVelocity(Plane oldPlane, Plane newPlane)
        {
            double XYDiff = Math.Sqrt((Math.Pow((newPlane.XCoordinate - oldPlane.XCoordinate),2) + Math.Pow((newPlane.YCoordinate - oldPlane.YCoordinate),2)));
            double AltitudeDiff = Math.Abs(oldPlane.Altitude - newPlane.Altitude);
            double DistanceMoved = Math.Sqrt((Math.Pow(XYDiff,2) + Math.Pow(AltitudeDiff,2)));
            double TimeUsed = Math.Abs(TimeStamptoSecInDouble(oldPlane.TimeStamp) -  TimeStamptoSecInDouble(newPlane.TimeStamp));

            return (DistanceMoved / TimeUsed);
        }

        public double TimeStamptoSecInDouble(string timeStamp) // Tager kun døgn 
        {
            double timeStampInSecs = 0;
            String substringHours = timeStamp.Substring(8, 2);
            String substringMinutes = timeStamp.Substring(10, 2);
            String substringSec = timeStamp.Substring(12, 2);
            String substringMSec = timeStamp.Substring(14, 3);

            timeStampInSecs += (60 * 60 * (double.Parse(substringHours)));
            timeStampInSecs += (60 * double.Parse(substringMinutes));
            timeStampInSecs += double.Parse(substringSec);
            timeStampInSecs += (double.Parse(substringMSec)/1000);
            Console.WriteLine($"Timestamp{TimeStamp} is {timeStampInSecs} secs"); // TODO delete
            return timeStampInSecs;
        }

        public int 
    }
}
