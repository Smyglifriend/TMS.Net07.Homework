using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class RecFibonacci
    {
        public static void Fibonacci()
        {
            Console.WriteLine("How many numbers to deduce from the fibbonacci sequence: ");
            int.TryParse(Console.ReadLine(), out var number);
            for (var i = 0; i < number; i++)
            {
                Console.Write($"{Rec_Fibonacci(i)} ");
            }
            Console.ReadLine();
        }
        private static int Rec_Fibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return Rec_Fibonacci(number - 1) + Rec_Fibonacci(number - 2);
            }
        }
    }
}
