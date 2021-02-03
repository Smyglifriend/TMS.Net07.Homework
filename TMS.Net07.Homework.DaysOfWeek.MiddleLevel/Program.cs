using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek.MiddleLevel
{
    class Program
    {
        static string GetDayOfWeekMiddleLevel(string date)
        {

            //DateTime objDate = Convert.ToDateTime(date);

            if (DateTime.TryParse(date, out var objDate))
            {
                return objDate.DayOfWeek.ToString();
            }
            else
            {

                return "Bad input!";
            }
        }
        static string GetDayOfWeekHardLevel(string date)
        {
            string[] num = date.Split('.');

            var day = Convert.ToInt32(num[0]);
            var month = Convert.ToInt32(num[1]);
            var year = Convert.ToInt32(num[2]);

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            if (month == 06)
            {
                if (day == 1) { Console.WriteLine("Monday"); }
                else if (day == 2) { Console.WriteLine("Tuesday"); }
                else if (day == 3) { Console.WriteLine("Wednsday"); }
                else if (day == 4) { Console.WriteLine("Thursday"); }
                else if (day == 5) { Console.WriteLine("Friday"); }
                else if (day == 6) { Console.WriteLine("Saturday"); }
                else if (day == 7) { Console.WriteLine("Sunday"); }
            }
            Console.WriteLine("\n");
            return date;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input date: ");
                var date = Console.ReadLine();
                if (date == "exit")
                {
                    Console.WriteLine("You closed the program!");
                    return;
                }

                var dayOfWeekFromMiddleLevel = GetDayOfWeekMiddleLevel(date);
                var dayOfWeekTimeFromHardLevel = GetDayOfWeekHardLevel(date);

                Console.WriteLine($"Result from middle level: {dayOfWeekFromMiddleLevel}");
                Console.WriteLine($"Result from hard level: {dayOfWeekTimeFromHardLevel}");
            }
        }
    }
}
