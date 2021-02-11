using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class FibonacciThroughArray
    {
        public static void MainFibonacciArray()
        {            
            Console.WriteLine("How many numbers to deduce from the fibbonacci sequence: ");
            int.TryParse(Console.ReadLine(), out var isnumber);
            if (isnumber < 0)
            {
                isnumber *= -1;
            }
            if (isnumber == 0)
            {
                return;
            }
            int[] array = new int[isnumber + 1];
            for (var i = 0; i < isnumber; i++)
            {
                Console.Write($"{FibonacciArray(i, array)} ");
            }
            Console.ReadLine();
        }
        private static int FibonacciArray(int n, int[] array)
        {
            if (n == 0 || n == 1)
            {
                array[n] = n;
                return n;
            }
            if (array[n] == 0)
            {
                array[n] = FibonacciArray(n - 2, array) + FibonacciArray(n - 1, array);
            }
           
            return array[n];            
        }
    }
}
