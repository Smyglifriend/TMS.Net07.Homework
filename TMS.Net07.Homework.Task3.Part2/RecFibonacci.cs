using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class ReccFibonacci
    {
        public static void Fibonacci()
        {
            Console.WriteLine("How many numbers to deduce from the fibbonacci sequence: ");
            int.TryParse(Console.ReadLine(), out var isnumber);
            if (isnumber < 0)
            {
                isnumber *= -1;
            }
            for (var i = 0; i < isnumber; i++)
            {
                Console.Write($"{RecFibonacci(i)} ");
            }
            Console.ReadLine();
        }
        private static int RecFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return RecFibonacci(number - 1) + RecFibonacci(number - 2);
            }
        }
    }
}
