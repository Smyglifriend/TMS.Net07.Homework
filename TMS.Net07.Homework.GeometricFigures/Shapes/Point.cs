using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point SetX(int newX)
        {
            return new Point(newX, Y);
        }
        public Point SetY(int newY)
        {
            return new Point(X, newY);
        }        
        public double GetDistance(Point target)
        {
            var width = this.X - target.X;
            var height = this.Y - target.Y;

            return Math.Sqrt(width * width + height * height);
        }
    }
}
