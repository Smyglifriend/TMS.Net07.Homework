using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {            
                Console.WriteLine("Press number 0 to exit\n");
                    Console.WriteLine("Enter the number: ");
                    if (Int32.TryParse(Console.ReadLine(), out int number))
                    {
                        Console.WriteLine(number);
                        Console.WriteLine("Excellent!!!");
                    }
                    else
                        Console.WriteLine("String coulde not be parsed");
                    if (number == 0)
                        break;
            }            
        }
    }
}
