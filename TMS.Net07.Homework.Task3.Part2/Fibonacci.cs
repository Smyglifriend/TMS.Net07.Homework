using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class Fibonacci
    {
        public static void MainFibonacci()
        {
            int now = 1, temp = 0, fake = 0;
            Console.WriteLine("How many numbers to deduce from the fibbonacci sequence: ");
            int.TryParse(Console.ReadLine(), out var number);
            Console.Write("0 1");
            for (int i = 2; i < number; i++)
            {
                fake = now;
                now += temp;
                Console.Write(string.Concat(" ", now));
                temp = fake;
            }
            Console.ReadLine();
        }
    }
}
