using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task3.Part2
{
    class Program
    {
        static int isnumber;
        static bool ConversationStatus;
        static void EnterNumber()
        {
            Console.WriteLine("Enter number of task:");
            Console.WriteLine($"1) Factorial {Environment.NewLine}2) Factorial through recursion{Environment.NewLine}" +
                $"3) Fibonacci number{Environment.NewLine}4) Fibonacci through recursion {Environment.NewLine}5) Exit");
            ConversationStatus = int.TryParse(Console.ReadLine(), out isnumber);
            
        }
        static void Main()
        {
            while (true)
            {
                EnterNumber();
                if (ConversationStatus)
                {
                    
                    switch (isnumber)
                    {
                        case 1:
                            Factorial.MianFactorial();
                            break;
                        case 2:
                            FactorialRecursion.MainRecFactorial();
                            break;
                        case 3:
                            Fibonacci.MainFibonacci();
                            break;
                        case 4:
                            ReccFibonacci.Fibonacci();
                            break;
                        case 5:
                            Console.WriteLine("You closed the program");
                            return;
                        default:
                            Console.WriteLine("Bad input");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bad input!");
                    EnterNumber();
                }
                Console.Clear();
            }
        }
    }
}
