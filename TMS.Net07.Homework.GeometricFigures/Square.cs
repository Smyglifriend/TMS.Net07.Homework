using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    class Square : Rectangle
    {
        public Square (Point a, Point b) : base(a, b)
        {

        }
        public override double GetSquare()
        {
            var check = CheckTrueOrFalse(A, B);
            if (check == true)
            {
                return base.GetSquare();
            }
            else
            {
                return -1;
            }
        }
        public override double GetPerimeter()
        {            
            var check  = CheckTrueOrFalse(A, B);
            if (check == true)
            {
                return base.GetPerimeter(); 
            }
            else
            {
                return -1;
            }
        }
        private bool CheckTrueOrFalse(Point a, Point b)
        {
            if (Math.Abs(a.X - b.X) == Math.Abs(a.Y - b.Y))
            {
                return true;
            }
            return false;
        }        
        protected override int GetWidth()
        {
            return Math.Abs(A.X - B.X);
        }
        protected override int GetHeigth()
        {
            return Math.Abs(A.Y - B.Y);
        }
    }
}
