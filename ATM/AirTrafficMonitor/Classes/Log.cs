using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM
{
    public class Log : ILog
    {

        public void WriteToLog(String PlaneTagA, String PlaneTagB, string TimeOfOccurrencce)
        {
            using (StreamWriter sw = File.AppendText("Log.txt"))
            {
                sw.WriteLine($"The two planes {PlaneTagA} and {PlaneTagB} had a separation event at {TimeOfOccurrencce}");
            }

        }
        /* public void ClearLog()
         {
             using (StreamWriter sw = new StreamWriter("Log.txt"))
             {
                 sw.Write("");
             }
         }
     } */
        //TODO: Remove low level test
        /*class Program
        {
             static void Main(string[] args)
             {
                 Log log = new Log();
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 log.WriteToLog("0556HH", "045KBH", "5TH Sep 2018 10:30:00:56");
                 Console.WriteLine("Clear Log?(y/n)");
                 string input = Console.ReadLine();
                 if (input=="y")
                 {
                     log.ClearLog();
                 }
             }
         }*/
    }
}
