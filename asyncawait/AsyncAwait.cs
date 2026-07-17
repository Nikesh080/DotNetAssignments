using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments.asyncawait
{
    internal class AsyncAwait
    {

        public static async Task DownloadData()
        {
            Console.WriteLine("Downloading data...");

            await Task.Delay(3000);

            Console.WriteLine("Download completed.");
        }


        public static async Task RunDemo()
        {
            Console.WriteLine("Async/Await Example");

            await DownloadData();

            Console.WriteLine("Program finished.");
        }
    }
}
