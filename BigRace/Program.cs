using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<France> France =new List<France>(10);
            France.Add(new France("Индира"));
            France.Add(new France("Ира"));
            France.Add(new France("Инна"));
            France.Add(new France("Анна"));
            France.Add(new France("Аня"));
            France.Add(new France("Глеб"));
            France.Add(new France("Миша"));
            France.Add(new France("Маша"));
            France.Add(new France("Рина"));
            France.Add(new France("Арина"));
        }
    }
}
