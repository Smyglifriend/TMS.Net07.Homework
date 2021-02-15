using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Program
    {// реализовать валидацию ввода для координат
        static void Main(string[] args)
        {
            int resultToConvertFigureNumber = 0;
            string pattern = @"drow\d$";

            while (true) {
                Console.WriteLine($"Choose a shape: {Environment.NewLine}" +
                    $"1) Rectangle{Environment.NewLine}" +
                    $"2) Sqaure{Environment.NewLine}" +
                    $"3) Triangle{Environment.NewLine}" +
                    $"4) Hexagon{Environment.NewLine}" +
                    $"5) Circle{Environment.NewLine}" +
                    $"Enter exit if you want close the program");

                var figureNumber = Console.ReadLine().ToLower();
                figureNumber = figureNumber.Replace(" ", string.Empty);
                Console.Clear();
                if (figureNumber == "exit")
                {
                    return;
                }
                if (Regex.IsMatch(figureNumber, pattern))
                {
                    figureNumber = figureNumber.Remove(0, 4);
                    resultToConvertFigureNumber = int.Parse(figureNumber);
                }
                

                var trueorfalse = int.TryParse(figureNumber, out var isfigurenumber);
                if (trueorfalse)
                {
                    bool firstResultToConvertForFirstPoint;
                    bool secindResultToConvertForFirstPoint;
                    bool firstResultToConvertForSecondPoint;
                    bool secindResultToConvertForSecondPoint;
                    bool thirdResultToConvertForFirstPoint;
                    bool thirdResultToConvertForSecondPoint;

                    int FirstCoordinateForFirstPoint;
                    int SecondCoordinateForFirstPoint;
                    int FirstCoordinateForSecondPoint;
                    int SecondCoordinateForSecondPoint;
                    int ThirdCoordinateForFirstPoint;
                    int ThirdCoordinateForSecondPoint;


                    switch (isfigurenumber | resultToConvertFigureNumber)
                    {
                        case 1:
                            Console.WriteLine("Rectangle!");
                            Console.WriteLine($"Enter coordinates for two points:{Environment.NewLine}" +
                                $"First point: ");

                            firstResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForFirstPoint);
                            secindResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForFirstPoint);

                            Console.WriteLine("Second Point: ");

                            firstResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForSecondPoint);
                            secindResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForSecondPoint);

                            var rectangle = new Rectangle(new Point(FirstCoordinateForFirstPoint, SecondCoordinateForFirstPoint),
                                new Point (FirstCoordinateForSecondPoint, SecondCoordinateForSecondPoint));

                            ShapeManager.PrintShapePerimeter(rectangle);
                            ShapeManager.PrintShapeSquare(rectangle);
                            Draw(rectangle);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Square!");
                            Console.WriteLine($"Enter coordinates for two points:{Environment.NewLine}" +
                                $"First point: ");

                            firstResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForFirstPoint);
                            secindResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForFirstPoint);

                            Console.WriteLine("Second Point: ");

                            firstResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForSecondPoint);
                            secindResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForSecondPoint);

                            var square = new Square(new Point(FirstCoordinateForFirstPoint, SecondCoordinateForFirstPoint),
                                new Point(FirstCoordinateForSecondPoint, SecondCoordinateForSecondPoint));

                            ShapeManager.PrintShapePerimeter(square);
                            ShapeManager.PrintShapeSquare(square);
                            Draw(square);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Triangle!");
                            Console.WriteLine($"Enter coordinates for two points:{Environment.NewLine}" +
                               $"First point: ");
                            firstResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForFirstPoint);
                            secindResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForFirstPoint);

                            Console.WriteLine("Second Point: ");
                            firstResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForSecondPoint);
                            secindResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForSecondPoint);

                            Console.WriteLine("Third point:");
                            thirdResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out ThirdCoordinateForFirstPoint);
                            thirdResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out ThirdCoordinateForSecondPoint);

                            var triangle = new Triangle(new Point(FirstCoordinateForFirstPoint, SecondCoordinateForFirstPoint),
                                new Point(FirstCoordinateForSecondPoint, SecondCoordinateForSecondPoint),
                                new Point(ThirdCoordinateForFirstPoint, ThirdCoordinateForSecondPoint));

                            ShapeManager.PrintShapePerimeter(triangle);
                            ShapeManager.PrintShapeSquare(triangle);
                            Draw(triangle);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Hexagon!");
                            Console.WriteLine($"Enter coordinates for two points:{Environment.NewLine}" +
                               $"First point: ");
                            firstResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForFirstPoint);
                            secindResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForFirstPoint);

                            Console.WriteLine("Second Point: ");
                            firstResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForSecondPoint);
                            secindResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForSecondPoint);
                            
                            var hexagon = new Hexagon(new Point(FirstCoordinateForFirstPoint, SecondCoordinateForFirstPoint),
                                new Point(FirstCoordinateForSecondPoint, SecondCoordinateForSecondPoint));

                            ShapeManager.PrintShapePerimeter(hexagon);
                            ShapeManager.PrintShapeSquare(hexagon);
                            Draw(hexagon);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Circle!");
                            Console.WriteLine($"Enter coordinates for two points:{Environment.NewLine}" +
                                                           $"First point: ");
                            firstResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForFirstPoint);
                            secindResultToConvertForFirstPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForFirstPoint);

                            Console.WriteLine("Second Point: ");
                            firstResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out FirstCoordinateForSecondPoint);
                            secindResultToConvertForSecondPoint = int.TryParse(Console.ReadLine(), out SecondCoordinateForSecondPoint);

                            var circle = new Circle(new Point(FirstCoordinateForFirstPoint, SecondCoordinateForFirstPoint),
                                new Point(FirstCoordinateForSecondPoint, SecondCoordinateForSecondPoint));

                            ShapeManager.PrintShapePerimeter(circle);
                            ShapeManager.PrintShapeSquare(circle);
                            Draw(circle);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter correct number");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        static void Draw(Shapes shape)
        {
            Drawer drawer = new ConsoleEngDescriptionDrawer();
            while (true)
            {
                Console.WriteLine("Enter ru or en");
                var str = Console.ReadLine().ToLower().ToLower();
                if (str == "en")
                {
                    break;
                }
                else if (str == "ru")
                {
                    drawer = new ConsoleRusDescriptionDrawer();
                    break;
                }
                else
                {
                    Console.WriteLine("Please, enter ru or en!");
                }
            }
            drawer.Draw(shape);
        }
    }    
}
