using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    interface ILog
    {
        void WriteToLog(String PlaneTagA, String PlaneTagB, string TimeOfOccurrencce);
    }
}
