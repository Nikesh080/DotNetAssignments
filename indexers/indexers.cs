using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments.indexer
{
    internal class indexers
    {
        private string[] employeeNames = new string[3];

        public string this[int index]
        {
            get
            {
                return employeeNames[index];
            }
            set
            {
                employeeNames[index] = value;
            }
        }

        public static void RunDemo()
        {
            Console.WriteLine();
            Console.WriteLine("Indexer Example");

            indexers emp = new indexers();

            emp[0] = "Ram";
            emp[1] = "Sita";
            emp[2] = "Shyam";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Employee {i + 1}: {emp[i]}");
            }

            Console.WriteLine();
        }
    }
}