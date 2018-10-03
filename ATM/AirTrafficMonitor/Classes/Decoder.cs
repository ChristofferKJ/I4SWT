using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Decoder : IDecoder // TODO test med eventhandler 
    {
        public List<Plane> planes = new List<Plane>();
        public List<Plane> Decode(List<string> ddata)
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
                flyet.CheckPlane(planes, flyet);
                
            }


            foreach (var plane in planes)
            {
                Console.WriteLine($"Tag {plane.Tag} X {plane.XCoordinate} Y {plane.YCoordinate} altitude {plane.Altitude} velocity {plane.Velocity} course {plane.Course}");
            }
            return planes; 
        }

    }
}

