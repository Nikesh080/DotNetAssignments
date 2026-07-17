using dotNetAssignments;
using DotNetAssignments.indexer;
using DotNetAssignments.DelegateandEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAssignments.asyncawait;

namespace DotNetAssignments
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
            //array
            jagged.Run();
            array3d.Run();

            //indexer
            indexers.RunDemo();

            //delegate and event
            delegatedemo.RunDemo();
            eventdemo.RunDemo();

            //async await
            Console.WriteLine();
            Console.WriteLine("async await demo");
            await AsyncAwait.RunDemo();
        }
    }
}
