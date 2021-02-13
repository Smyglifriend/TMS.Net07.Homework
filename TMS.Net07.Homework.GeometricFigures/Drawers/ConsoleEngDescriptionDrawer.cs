using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    //Создать класс ConsoleDescriptionDrawer, который бы наследовался
    //    от класса Drawer и при вызове метода Draw выводил в консоль название
    //    фигуры и координаты её углов(в случае окружности - координаты центра и радиус).
    class ConsoleEngDescriptionDrawer : Drawer
    {
        public override void Draw(Shapes shape)
        {
            var coordinates = shape.GetCoordinates();
            Console.WriteLine($"Shape is {shape.GetType().Name} with points {coordinates}");
        }
    }
}
