using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(
                new Point(0, 0),
                new Point(5, 8));
            var triangle = new Triangle(
                new Point(0, 0),
                new Point(4, 4),
                new Point(0, 4));
            var square = new Square(
                new Point (0, 0),
                new Point (4, 4));
            var hexagon = new Hexagon(
                new Point(0, 0),
                new Point(4, 4));
            var circle = new Circle(
                new Point(6,5),
                new Point(3,5));

            Console.WriteLine(rectangle);
            Console.WriteLine(square);
            Console.WriteLine(triangle);
            Console.WriteLine(hexagon);
            Console.WriteLine(circle);
            Console.WriteLine();

            ShapeManager.PrintShapePerimeter(triangle);
            ShapeManager.PrintShapeSquare(triangle);
            Console.WriteLine();

            ShapeManager.PrintShapePerimeter(rectangle);
            ShapeManager.PrintShapeSquare(rectangle);
            Console.WriteLine();

            ShapeManager.PrintShapePerimeter(square);
            ShapeManager.PrintShapeSquare(square);
            Console.WriteLine();

            ShapeManager.PrintShapePerimeter(hexagon);
            ShapeManager.PrintShapeSquare(hexagon);
            Console.WriteLine();

            ShapeManager.PrintShapePerimeter(circle);
            ShapeManager.PrintShapeSquare(circle);
        }
    }
}
