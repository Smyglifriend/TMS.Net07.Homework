using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMS.Net07.Homework.MasterCalculator
{          

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string[] pattern = new string[] { @"^sqr\d+$", @"^sqrt\d+$", @"^\d+pow\d+$", @"^\d+\+\d+$", @"^\d+\-\d+$", @"^\d+\*\d+$", @"^\d+\/\d+$", @"^\d+\%\d+$" };
                Console.WriteLine(@"Enter ""exit"" to close calculator");
                Console.WriteLine("Enter your operation");
                var input = Console.ReadLine().ToLower();
                input = input.Replace(" ", string.Empty);
                if (input == "exit")
                {
                    return;
                }
                int operation = 8;
                string expressionConvertToString = "";
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (Regex.IsMatch(input, pattern[i]))
                    {
                        Match expression = Regex.Match(input, pattern[i]);
                        expressionConvertToString = expression.ToString();
                        operation = i;
                    }
                }
                switch (operation)
                {
                    case 0:
                        Console.WriteLine($"Result: {SqrFunction(expressionConvertToString)}");
                        break;
                    case 1:
                        Console.WriteLine($"Result: {SqrtFunction(expressionConvertToString)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {PowFunction(expressionConvertToString) }");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {SumFunction(expressionConvertToString)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result: {DifferenceFunction(expressionConvertToString)}");
                        break;
                    case 5:
                        Console.WriteLine($"Result: {MultiplicationFunction(expressionConvertToString)}");
                        break;
                    case 6:
                        Console.WriteLine($"Result: {DivisionFunction(expressionConvertToString)}");
                        break;
                    case 7:
                        Console.WriteLine($"Result: {RemainderTheDivisionFunction(expressionConvertToString)}");
                        break;
                    case 8:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
        static double SqrFunction(string expression)
        {
            string solution = expression.Remove(0,3);
            return Convert.ToDouble(solution) * Convert.ToDouble(solution);
        }
        static double SqrtFunction(string expression)
        {
            string solution = expression.Remove(0, 4);
            double solutionConvertToDouble = double.Parse(solution);
            return Math.Sqrt(solutionConvertToDouble);
        }
        static double PowFunction(string expression)
        {
            string[] subString = expression.Split(new string[] { "pow" }, StringSplitOptions.RemoveEmptyEntries);
            return Math.Pow(double.Parse(subString[0]), double.Parse(subString[1]));
            //string[] solution = expression.Replace("pow",".").Split('.');            
            //return Math.Pow(double.Parse(solution[0]), double.Parse(solution[1]));
        }
        static double SumFunction(string expression)
        {
            string[] solution = expression.Split('+');
            return double.Parse(solution[0]) + double.Parse(solution[1]);
        }
        static double DifferenceFunction(string expression)
        {
            string[] solution = expression.Split('-');
            return double.Parse(solution[0]) - double.Parse(solution[1]);
        }
        static double MultiplicationFunction(string expression)
        {
            string[] solution = expression.Split('*');
            return double.Parse(solution[0]) * double.Parse(solution[1]);
        }
        static double DivisionFunction(string expression)
        {
            string[] solution = expression.Split('/');
            return double.Parse(solution[0]) / double.Parse(solution[1]);
        }
        static double RemainderTheDivisionFunction(string expression)
        {
            string[] solution = expression.Split('%');
            return double.Parse(solution[0]) % double.Parse(solution[1]);
        }
    }
}
