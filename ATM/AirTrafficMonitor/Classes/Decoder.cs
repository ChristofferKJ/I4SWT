using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Decoder : IDecoder // TODO test med eventhandler 
    {
        public List<Plane> planes = new List<Plane>();
        public void Decode(List<string> ddata)
        {
            Plane testfly = new Plane("12","1000", "1000", "1000", "10001212000001000");
            planes.Add(testfly);
            foreach (string fly in ddata)
            {

                string[] split = fly.Split(';');

                string tag = split[0];
                string X_Coord = split[1];
                string Y_Coord = split[2];
                string Alt = split[3];
                string Timestamp = split[4];
                
                Plane flyet = new Plane(tag, X_Coord, Y_Coord, Alt, Timestamp);
                
                bool newPlaneCreated = false;
                foreach (var plane in planes)
                {
                    if (flyet.Tag == plane.Tag)
                    {
                        
                        flyet = flyet.CheckPlane(flyet,plane);
                        planes.Remove(plane);
                        planes.Add(flyet);
                        newPlaneCreated = true;
                        break;
                    }


                }

                if (!newPlaneCreated)
                {
                    planes.Add(flyet);
                }
                




            }
            foreach (var plane in planes)
            {
                Console.WriteLine($"Tag {plane.Tag} X {plane.XCoordinate} Y {plane.YCoordinate} altitude {plane.Altitude} velocity {plane.Velocity} course {plane.Course}");
            }
        }

    }
}

