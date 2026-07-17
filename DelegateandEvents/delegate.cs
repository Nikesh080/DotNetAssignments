using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments.DelegateandEvents
{
    public delegate void Notification(string text);

    internal class delegatedemo
    {

        public static void ShowAlert(string text)
        {
            Console.WriteLine("Alert: " + text);
        }

        public static void ShowPopup(string text)
        {
            Console.WriteLine("Popup: " + text);
        }


        public static void RunDemo()
        {
            Console.WriteLine("delegate example");
            Notification notify = null;

            notify += ShowAlert;
            notify += ShowPopup;

            Console.WriteLine("After registering notification methods:");
            notify("System Started!");

            notify -= ShowPopup;

            Console.WriteLine("\nAfter unregistering Popup method:");
            notify("Process Completed!");
        }
    }
}