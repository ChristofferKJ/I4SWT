﻿using System;
using TransponderReceiver;

namespace ATM
{
    public class HandleRTD : ITransponderReceiver
    {
        public event EventHandler<RawTransponderDataEventArgs> TransponderDataReady;

        public void handleEventData()
        {
            if (TransponderDataReady == null)
            {
                Console.WriteLine("Transponder Data error");
            }

            while (true)
            {
                TransponderDataReady?.Invoke(this, null);
            }
        }
    }

    public class RTDListener
    {
        RTDListener()
        {

        }

        public void Listen(HandleRTD handler)
        {
            handler.TransponderDataReady += OnDataReady;

            public class HandleRTD
        {
            private ITransponderReceiver Receiver;

            public HandleRTD(ITransponderReceiver receiver)
            {
                Receiver = receiver;
                Receiver.TransponderDataReady += OnDataReady;
            }

            /*  private void OnDataReady(object sender, RawTransponderDataEventArgs e)
              {
                  Console.WriteLine("Data ready");
              }
          }

                  foreach (var data in e.TransponderData)
                      Console.WriteLine($"Data: {data}");
              }
          }
          */
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




        } } }