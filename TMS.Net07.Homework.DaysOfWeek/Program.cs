using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    //First level
    enum DaysOFWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    class Program
    {
        static void Main()
        {
            DayOfWeek day;
            Console.WriteLine("Hello! Please enter the day of week that you want translate:");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    return;
                }
                try
                {
                    day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad input!");
                    return;
                }
                switch (day)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("Понедельник");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Вторник");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("Среда");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Четверг");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("Пятница");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Суббота");
                        break;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
        }
    }
}
