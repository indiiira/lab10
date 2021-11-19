using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Rectangle:Point,IMove
    {
       public double Width { get; set; }
        public double Height{ get; set; }
        public Rectangle(string name, Visibl visibility, Colour colour,double height, double width) : base(name,visibility,colour)
        {
            this.Height = height;
            this.Width = width;
         
        }
        public override double Area()
        {

            return Height * Width;
            
        }
        public override void GetInfo()
        {
            Console.WriteLine($" Фигура: {name},  Состояние {visibility}, Цвет {colour}, Ширина {Width}, Высота {Height}  ");
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
