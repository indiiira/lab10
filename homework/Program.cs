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
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.GetInfo());
            //Console.WriteLine(circle.Moves());
            Console.ReadKey();
        }
    }
}
