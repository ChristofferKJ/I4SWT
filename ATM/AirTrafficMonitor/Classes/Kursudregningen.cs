using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Kursudregningen
    {
    }

    public double CalCourse(Plane oldPlane, Plane newPlane)
    {
        double dx = oldPlane.XCoordinate - newPlane.XCoordinate;
        double dy = oldPlane.YCoordinate - newPlane.YCoordinate;

        return Math.Atan2(dy, dx) * (180 / Math.PI);
    }
}
