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
        public Point C { get; }

        public Rectangle(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            C = b ?? throw new ArgumentNullException(nameof(b));
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
        public override string GetCoordinates()
        { 
            return $"A({A.X}, {A.Y}), B({A.X}, {C.Y}), C({C.X}, {C.Y}), D({C.X}, {A.Y})";
        }

        protected virtual int GetWidth()
        {
            return Math.Abs(A.X - C.X);
        }
        protected virtual int GetHeigth()
        {
            return Math.Abs(A.Y - C.Y);
        }


    }
}
