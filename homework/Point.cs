using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Point : Figure
    {
        public Point(string name, Visibl visibility, Colour colour) : base(name, visibility, colour)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($" Фигура: {name},  Состояние {visibility}, Цвет {colour}");
        }

        public override double Area()
        {
            return 1;
        }
    }
}
