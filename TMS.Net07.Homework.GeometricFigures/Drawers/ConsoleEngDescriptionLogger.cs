using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class ConsoleEngDescriptionLogger : Logger
    {
        //public override void Log(Shapes shape)
        //{
        //    var coordinates = shape.GetCoordinates();
        //    Console.WriteLine($"Shape is {shape.GetType().Name} with points {coordinates}");
        //}
        //public override void PrintShapePerimeter(Shapes shape)
        //{
        //    Console.WriteLine($"Perimeter of {shape.GetType().Name} is {shape.GetPerimeter()}");
        //}
        //public override void PrintShapeSquare(Shapes shape)
        //{
        //    Console.WriteLine($"Square of {shape.GetType().Name} is {shape.GetSquare()}");
        //}
        public override string ToString(Shapes shape)
        {
            var coordinates = shape.GetCoordinates();
            Console.WriteLine($"Shape is {shape.GetType().Name} with points {coordinates}");
            Console.WriteLine($"Perimeter of {shape.GetType().Name} is {shape.GetPerimeter()}");
            Console.WriteLine($"Square of {shape.GetType().Name} is {shape.GetSquare()}");
            return "Sosi";
        }
    }
}

