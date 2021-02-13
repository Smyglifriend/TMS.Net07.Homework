using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Rectangle : Shapes
    {
        public Point A { get; }
        public Point B { get; }

        public Rectangle(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
        }
        public override double GetPerimeter()
        {
            var wigth = GetWidth();
            var heigth = GetHeigth();

            return  (wigth + heigth) * 2;
        }

        public override double GetSquare()
        {
            var wigth = GetWidth();
            var heigth = GetHeigth();

            return wigth * heigth;
        }

        protected virtual int GetWidth()
        {
            return Math.Abs(A.X - B.X);
        }
        protected virtual int GetHeigth()
        {
            return Math.Abs(A.Y - B.Y);
        }
    }
}
