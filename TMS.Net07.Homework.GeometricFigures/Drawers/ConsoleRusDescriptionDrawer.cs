using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public class ConsoleRusDescriptionDrawer : Drawer
    {
        public override void Draw(Shapes shape)
        {
            var coordinates = shape.GetCoordinates();
            Console.WriteLine($"Фигура {shape.GetType().Name} с точками {coordinates}");
        }
    }
}
