using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public abstract class Shapes
    {
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public abstract string GetCoordinates();
        public override string ToString()
        {
            var coordinates = GetCoordinates();
            var result = $"Shape is {this.GetType().Name} with points {coordinates}";
            return result;
        }
    }
}
