using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Triangle : Shapes
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            C = c ?? throw new ArgumentNullException(nameof(c));
        }
        public override double GetPerimeter()
        {
            return A.GetDistance(B) + B.GetDistance(C) + C.GetDistance(B);
        }

        public override double GetSquare()
        {
            var firstSide = A.GetDistance(B);
            var secondSide = B.GetDistance(C);
            var thirdSide = C.GetDistance(A);

            return Math.Sqrt(firstSide * firstSide + secondSide * secondSide + thirdSide * thirdSide);
        }

    }
}
