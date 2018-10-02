﻿using System;
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
            
            Console.WriteLine("Data ready");
            foreach (var data in e.TransponderData)
            {
                Console.WriteLine($"Data: {data}");
                
            }

            //List<Plane> planes = myDecoder.Decode(e.TransponderData);

            foreach (var plane in planes)
            {
                Console.WriteLine($"Tag {plane.Tag} X {plane.XCoordinate} Y {plane.YCoordinate} altitude {plane.Altitude} velocity {plane.Velocity} course {plane.Course}");
            }

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