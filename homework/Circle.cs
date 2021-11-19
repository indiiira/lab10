using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Circle:Point,IMove
    {

        public double r;
        public Circle(string name, Visibl visibility, Colour colour, double r):base(name, visibility, colour)
        {
      
            this.r = r;
        }
        public override double Area()
        {
            return  Math.PI * r*r;
            
        }

        public override void GetInfo()
        {
            Console.WriteLine($" Фигура: {name},  Состояние {visibility}, Цвет {colour}, Радиус{r}");
        }

        public void Moves()
        {
            Console.WriteLine("Фигура движется по вертикали:");
            Console.WriteLine("Вверх на три клетки");
            Console.WriteLine("Фигура движется по горизонтали:");
            Console.WriteLine("Вправо на десять клеток");
            Console.WriteLine("Фигура движется по вертикали:");
            Console.WriteLine("Вниз на одну клетку ");
            Console.WriteLine("Фигура движется по горизонтали:");
            Console.WriteLine("Влево на пять клеток");
        }
    }
}
