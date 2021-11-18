using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Move:IMove
    {
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
