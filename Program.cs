using dotNetAssignments;
using DotNetAssignments.indexer;
using DotNetAssignments.DelegateandEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            jagged.Run();
            array3d.Run();

            //indexer
            indexers.RunDemo();

            //delegate and event
            delegatedemo.RunDemo();
            eventdemo.RunDemo();

        }
    }
}
