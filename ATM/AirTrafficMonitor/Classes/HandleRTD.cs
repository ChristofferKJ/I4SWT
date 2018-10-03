using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using TransponderReceiver;

namespace ATM
{

    public class HandleRTD 
    {

        private ITransponderReceiver Receiver;

      
        public HandleRTD(ITransponderReceiver receiver)
        {
            Receiver = receiver;
            Receiver.TransponderDataReady += OnDataReady;
        }
        private void OnDataReady(object sender, RawTransponderDataEventArgs e)
        {
            Decoder myDecoder = new Decoder();
            
            Console.WriteLine("Data ready");
            foreach (var data in e.TransponderData)
            {
                Console.WriteLine($"Data: {data}");
                
            }

            //
           myDecoder.Decode(e.TransponderData);

           
        }
    }
          
            /*      How to use the TransponderRecieverFactory 
                    // Using the real transponder data receiver
                    var receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
                    var receiver = TransponderReceiverFactory.CreateTransponderDataReceiver(); // new

                    // Dependency injection with the real TDR
                    var system = new TransponderReceiverUser.TransponderReceiverClient(receiver);
                    var system = new HandleRTD(receiver); // new

                    // Let the real TDR execute in the background
                    while (true)
                        Thread.Sleep(1000);
             */




}