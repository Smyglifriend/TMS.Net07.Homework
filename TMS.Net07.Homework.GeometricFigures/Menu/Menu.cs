using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TMS.Net07.Homework.GeometricFigures
{
    public static class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Enter your figure: ");
            var input = Console.ReadLine()?.Trim().ToLower().Replace(" ", "");
            if (input == "exit")
            {
                return;
            }

            var shapes = Parser.Parse(input);
            Draw(shapes);
            //var triangle = new Triangle(points[0], points[1], points[2]);
            //var rectangle = new Rectangle(points[0], points[1]);




            void Draw(Shapes shape)
            {

                Logger drawer = new ConsoleEngDescriptionLogger();
                while (true)
                {
                    Console.WriteLine("Enter ru or en");
                    var str = Console.ReadLine()?.ToLower().ToLower();
                    if (str == "en")
                    {
                        break;
                    }
                    else if (str == "ru")
                    {
                        drawer = new ConsoleRusDescriptionLogger();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter ru or en!");
                    }
                }
                Console.WriteLine(shape);
            }
        }
    }
}