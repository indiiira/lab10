using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", Visibl.vision, Colour.Black,3);
            circle.GetInfo();
            Console.WriteLine($"Площадь круга {circle.Area()}");
            circle.Moves();


            Rectangle rectangle = new Rectangle("Rectangle", Visibl.vision, Colour.Yellow, 5,6);

            rectangle.GetInfo();
            Console.WriteLine($"Площадь прямоугольника {rectangle.Area()}");
            rectangle.Moves();
            Console.ReadKey();
        }
    }
}
