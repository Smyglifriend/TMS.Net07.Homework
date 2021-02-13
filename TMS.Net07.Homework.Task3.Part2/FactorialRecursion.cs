using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class FactorialRecursion
    {
        public static void MainRecFactorial()
        {
            Console.WriteLine("Enter the number: ");
            var boolean = int.TryParse(Console.ReadLine(), out var isnumber);
            if (!boolean)
            {
                Console.WriteLine("Enter the NUMBER!!!");
                Console.ReadLine();
                return;
            }
            if (isnumber < 0)
            {
                isnumber *= -1;
            }
            Console.WriteLine($"Factorial of a {isnumber} through recursion is: {Factoriaal(isnumber)}");
            Console.ReadLine();
        }
        private static int Factoriaal(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factoriaal(number - 1);
            }
        }
    }
}
