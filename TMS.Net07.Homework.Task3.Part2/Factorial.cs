using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class Factorial
    {
        public static void MianFactorial()
        {
            Console.WriteLine("Input your number:");
            var boolean = int.TryParse(Console.ReadLine(), out int isnumber);
            if (boolean == false)
            {
                Console.WriteLine("Bad input factorial");
                return;
            }
            if (isnumber < 0)
            {
                isnumber *= -1;
            }
            var factorial = 1;
            for (int i = 1; i <= isnumber; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {isnumber} is: {factorial}");
            Console.ReadLine();
        }
    }
}
