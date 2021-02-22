using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public class ConsoleRusDescriptionLogger : Logger
    {
        //public override void Log(Shapes shape)
        //{
        //    var coordinates = shape.GetCoordinates();
        //    Console.WriteLine($"Фигура {shape.GetType().Name} с точками {coordinates}");
        //}
        //public override void PrintShapePerimeter(Shapes shape)
        //{
        //    Console.WriteLine($"Периметр {shape.GetType().Name} равен {shape.GetPerimeter()} см");
        //}
        //public override void PrintShapeSquare(Shapes shape)
        //{
        //    Console.WriteLine($"Площадь {shape.GetType().Name} равно {shape.GetSquare()} см квадратных");
        //}
        public override string ToString(Shapes shape)
        {
            var coordinates = shape.GetCoordinates();
            return $"Фигура {shape.GetType().Name} с точками {coordinates}" +
                   $"Периметр {shape.GetType().Name} равен {shape.GetPerimeter()} см" +
                   $"Площадь {shape.GetType().Name} равно {shape.GetSquare()} см квадратных";

            //Console.WriteLine($"Фигура {shape.GetType().Name} с точками {coordinates}");
            //Console.WriteLine($"Периметр {shape.GetType().Name} равен {shape.GetPerimeter()} см");
            //Console.WriteLine($"Площадь {shape.GetType().Name} равно {shape.GetSquare()} см квадратных");
        }
    }
}
