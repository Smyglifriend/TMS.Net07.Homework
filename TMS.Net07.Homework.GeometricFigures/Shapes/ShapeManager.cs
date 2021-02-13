using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public static class ShapeManager
    {
        public static void PrintShapePerimeter(Shapes shape)
        {
            Console.WriteLine($"Perimeter of {shape.GetType().Name} is {shape.GetPerimeter()}");
        }
        public static void PrintShapeSquare(Shapes shape)
        {
            Console.WriteLine($"Square of {shape.GetType().Name} is {shape.GetSquare()}");
        }
    }
}
