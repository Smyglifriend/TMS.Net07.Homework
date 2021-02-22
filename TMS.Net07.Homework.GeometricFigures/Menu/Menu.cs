using System;

namespace TMS.Net07.Homework.GeometricFigures.Menu
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
            Console.ReadKey();
        }

        private static void Draw(Shapes shape)
        {
            while (true)
            {
                Console.WriteLine("Enter ru or en");
                var str = Console.ReadLine()?.ToLower().ToLower();
                Logger drawer;
                if (str == "en")
                {
                    drawer = new ConsoleEngDescriptionLogger();
                    drawer.Log(shape);
                    break;
                } 
                if (str == "ru")
                {
                    drawer = new ConsoleRusDescriptionLogger();
                    drawer.Log(shape);
                    break;
                }
                Console.WriteLine("Please, enter ru or en!");
            }
        }
    }
}