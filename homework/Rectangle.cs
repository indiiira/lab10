using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Rectangle:Point
    {
       public double Width { get; set; }
        public double Height{ get; set; }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
         
        }
        public override double Area()
        {

            double S = Height * Width;
            return S;
        }
    }
}
