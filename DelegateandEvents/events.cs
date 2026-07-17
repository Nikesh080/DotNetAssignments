using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments.DelegateandEvents
{

    internal class eventdemo
    {

        public event Action<string> Notify;


        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Notification...");
            Notify?.Invoke(message);
        }

        public static void DisplayOnScreen(string message)
        {
            Console.WriteLine("Screen: " + message);
        }

        public static void SaveToLog(string message)
        {
            Console.WriteLine("Log: " + message);
        }

        public static void RunDemo()
        {
            Console.WriteLine();
            Console.WriteLine("events example");
            eventdemo obj = new eventdemo();

            obj.Notify += DisplayOnScreen;
            obj.Notify += SaveToLog;

            Console.WriteLine("After subscribing handlers:");
            obj.SendNotification("Welcome!");

            obj.Notify -= SaveToLog;

            Console.WriteLine("\nAfter unsubscribing Log handler:");
            obj.SendNotification("Hello Again!");
        }
    }
}