using System;
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
        }

        private void OnDataReady(object sender, RawTransponderDataEventArgs e)
        {
            Console.WriteLine("Data ready");
        }
    }
}