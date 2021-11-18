using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Circle:Point
    {

        public double R { get; set; }
        public Circle( double r)
        {
      
            this.R = r;
        }
        public override double Area()
        {
            double s = 2 * Math.PI * R;
            return s;
        }
            
    }
}
