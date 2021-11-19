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
            List<IGame> games = new List<IGame> { new Beach(), new Fishing(), new Hill(), new Mousetrap(), new Postmen(), new Sea(), new Calmar() };
            string[] Russian = new string[15] { "Иван", "Андрей", "Яков", "Юрий", "Татьяна", "Мария", "Авдотья", "Елизавета", "Станислав", "Лис", "Гаара", "Нико", "Анко", "Грей", "Киба" };
            string[] France = new string[15] { "Адель", "Женя", "Джераль", "Жеральд", "Жерар", "Люси", "Ванда", "Игнил", "Сакура", "Саске", "Акира", "Жаннет", "Жоан", "Жереми", "Жанна" };
            string[] China = new string[15] { "Чон", "Сокджин", "Джин", "Юнбин", "Чонгук", "Тэхен", "Ким", "Намджун", "Юнги", "Мин", "Сехун", "Кай", "Минхо", "Сюзи", "Айю" };
            string[] Ukraine = new string[15] { "Мика", "Миша", "Дима", "Оля", "Яра", "Микола", "Асина", "Петя", "Хизаши", "Олина", "Боруто", "Хинаба", "Ангел", "Неджи", "Хината" };
            foreach (var game in games)
            {
                Team russia = new Team("Россия", Russian, game);
                Team china = new Team("Китай", China, game);
                Team ukraine = new Team("Украина", Ukraine, game);
                Team france = new Team("Франция", France, game);
                russia.PlayGame();
                france.PlayGame();
                china.PlayGame();
                ukraine.PlayGame();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
