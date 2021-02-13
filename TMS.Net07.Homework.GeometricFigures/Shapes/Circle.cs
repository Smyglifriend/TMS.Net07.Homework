using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Circle : Hexagon
    {
        public Circle(Point a, Point b): base(a, b)
        {
        }
        public override double GetPerimeter()
        {
            var radius = GetRadius();
            return radius * 2 * Math.PI;
        }

        public override double GetSquare()
        {
            var radius = GetRadius();
            return radius * radius * Math.PI;
        }
        protected override double GetRadius()
        {
            var firstVariable = GetWidth();
            var secondVariable = GetHeigth();
            return Math.Sqrt(firstVariable * firstVariable + secondVariable * secondVariable);
        }
        protected override int GetWidth()
        {
            return Math.Abs(A.X - C.X);
        }
        protected override int GetHeigth()
        {
            return Math.Abs(A.Y - C.Y);
        }
        public override string GetCoordinates()
        {
            var radius = GetRadius();
            return $"Centre A({A.X}, {A.Y}) with radius is {radius} sm";
        }
    }
}
