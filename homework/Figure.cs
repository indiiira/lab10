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
    enum Colour
    {
        Red,
        Yellow,
        Blue,
        Green,
        Black,
    }
    abstract class Figure
    {

        public string name;
        public Visibl visibility;
        public Colour colour ;
      
        public Figure(string name, Visibl visibility, Colour colour)
        {
            this.name = name;
            this.visibility = visibility;
            this.colour = colour;
        }
        public string Name
        {
            get { return name; }
        }
        public abstract void GetInfo();
        
           
        





        public abstract double Area();
        
        
        
        
      
    }
}
