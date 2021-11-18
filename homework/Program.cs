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
            Figure bob = new Rectangle("Прямоугольник", 1, "черный");
            bob.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            bob.MakeDinner(new SaladMeal());
        }
    }
}
