using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    //  Реализовать иерархию классов геометрических фигур.
    //- должно быть минимум 5 фигур(количество классов может отличаться от количества фигур)
    //- все фигуры должны либо напрямую, либо через промежуточный класс наследоваться от одного
    //  базового класса Shape
    //- подумать, что от чего должно наследоваться: квадрат от прямоугольника, либо прямоугольник
    //  от квадрата? Или же есть ещё какой-то вариант?
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
                new Point(0,0),
                new Point(1,1));

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
