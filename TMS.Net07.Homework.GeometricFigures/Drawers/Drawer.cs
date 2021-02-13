using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public abstract class Drawer
    {
        //    Создать класс ConsoleRenderDrawer, который бы наследовался от класса
        //        Drawer и при вызове метода Draw рисовал геометрические фигуры в консоли
        //        .Рисовать можно любым способом.Можно не сохранять размер фигуры - главное,
        //            чтобы из рисунка было ясно, что за фигура нарисована.
        //- Замена ConsoleRenderDrawer на ConsoleDrawer должна осуществляться изменением одной строчки
        //            кода.
        public abstract void Draw(Shapes shape);

    }
}
