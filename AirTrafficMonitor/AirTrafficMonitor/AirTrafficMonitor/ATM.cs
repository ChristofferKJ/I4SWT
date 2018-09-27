using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{


    namespace TransponderReceiver
    {
        public class RawTransponderDataEventArgs : EventArgs
        {
            public RawTransponderDataEventArgs(List<string> transponderData)
            {
                TransponderData = transponderData;
            }
            public List<string> TransponderData { get; }
        }
        public interface ITransponderReceiver
        {
            event EventHandler<RawTransponderDataEventArgs> TransponderDataReady;
        }

    }

    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TransponderReceiver.RawTransponderDataEventArgs(););

        }


    }
}
