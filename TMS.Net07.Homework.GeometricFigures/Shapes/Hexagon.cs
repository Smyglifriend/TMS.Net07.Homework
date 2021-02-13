using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Hexagon : Rectangle
    {
        public Hexagon(Point a, Point b) : base(a, b)
        {
        }
        public override double GetPerimeter()
        {
            var radius = GetRadius();
            return radius * 6;
        }
        public override double GetSquare()
        {
            var size = GetRadius();
            return (3 * Math.Sqrt(3) * size * size) / 2;
        }
        protected virtual double GetRadius()
        {
            var firstVariable = GetWidth();
            var secondVariable = GetHeigth();
            return Math.Sqrt(firstVariable * firstVariable + secondVariable * secondVariable);
        }
        protected override int GetWidth()
        {
            return Math.Abs(C.X - A.X);
        }
        protected override int GetHeigth()
        {
            return Math.Abs(C.Y - A.Y);
        }
        public override string GetCoordinates()
        {
            return $"A({A.X}, {A.Y}), B({C.X}, {C.Y}) and many other points";
        }
    }
}
