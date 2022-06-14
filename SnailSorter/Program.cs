using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsApp;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr =
            {
                new []{ 1, 2, 3, 4, 5, 6, 7},
                new []{ 8, 9, 10, 11, 12, 13, 14},
                new []{ 15, 16, 17, 18, 19, 20, 21},
                new []{ 22, 23, 24, 25, 26, 27, 28},
                new []{ 29, 30, 31, 32, 33, 34, 35}
            };
            int[] result = SnailSolution.Snail(arr);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

