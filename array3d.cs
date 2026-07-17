using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetAssignments
{
    internal class array3d
    {
        public static void Run()
        {
            int[,,] numbers =
            {
            {
                {1, 2},
                {3, 4}
            },
            {
                {5, 6},
                {7, 8}
            }
        };

            Console.WriteLine("3D Multidimensional Array:");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(2); k++)
                    {
                        Console.WriteLine($"numbers[{i},{j},{k}] = {numbers[i, j, k]}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
