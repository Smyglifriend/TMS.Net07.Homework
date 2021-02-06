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
            var boolean = int.TryParse(Console.ReadLine(), out var number);
            if (boolean == false)
            {
                Console.WriteLine("Enter the NUMBER!!!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Factorial of a {number} through recursion is: {Factoriaal(number)}");
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
