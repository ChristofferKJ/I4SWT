using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM
{
    public class Rendition
    {
        static void Main()
        {
            var receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
            var system = new HandleRTD(receiver);
            


            while (true)
                Thread.Sleep(1000);





        }
    }
}
