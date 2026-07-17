using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    internal class jagged
    {
        public static void Run()
        {

            int[][] jaggedMatrix = new int[3][]
            {
                new int[3]{1,2,3},
                new int[4]{3,4,5,6},
                new int[5]{5,4,7,8,9}
            };
            Console.WriteLine("jagged array");
            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                Console.Write($"Row {i}: ");

                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}