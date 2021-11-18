using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    enum Visibl
    {
        vision,
        notvision,
    }

     abstract class Figure
    {
        
        public string name;
        public Visibl visibl;
        public string colour ;

        public string Name
        {
            get { return name; }
        }
        public string Colour
        {
            get { return colour; }
        }
       
        public void GetInfo()
        {
            Console.WriteLine($" Фигура: {name},  Состояние {visibl}, Цвет {colour}");
        }

        public Figure(string name, Visibl visibl, string colour)
        {
            this.name = name;
            this.visibl = visibl;
            this.colour = colour;
        }
        public void MakeMove(IMove move)
        {
            move.Moves();
        }
        public abstract double Area();
    }
}
