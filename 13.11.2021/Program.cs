using System;

namespace _13._11._2021
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();
            bool flag = true;
            string answer1;
            string answer2;
            string str = "";
            while (flag)
            {

                Console.WriteLine("Если хотите использовать шифр A нажмите 1, если шифр B нажмите 2, хотите выйти 0");
                answer1 = Console.ReadLine();

                if (Equals(answer1, "1"))
                {


                    Console.WriteLine("Если хотите зашифровать строку нажмите 1, если дешифровать 2");
                    answer2 = Console.ReadLine();
                    if (Equals(answer2, "1"))
                    {
                        Console.WriteLine("Введите строку");
                        str = Console.ReadLine();


                        Console.WriteLine("Зашифрованная строка" + aCipher.Encode(str));
                    }
                    else if (Equals(answer2, "2"))
                    {
                        Console.WriteLine("Введите строку");
                        str = Console.ReadLine();


                        Console.WriteLine("Расшифрованная строка" + aCipher.Decode(str));
                    }



                }


                if (Equals(answer1, "2"))
                {
                    Console.WriteLine("Если хотите зашифровать строку нажмите 1, если дешифровать 2");
                    answer2 = Console.ReadLine();
                    {
                        if (Equals(answer2, "1"))
                        {
                            Console.WriteLine("Введите строку");
                            str = Console.ReadLine();


                            Console.WriteLine("Зашифрованная строка " + bCipher.Encode(str));
                        }
                        else if (Equals(answer2, "2"))
                        {
                            Console.WriteLine("Введите строку");
                        }

                        str = Console.ReadLine();

                        Console.WriteLine("Расшифрованная строка " + bCipher.Encode(str));
                    }
                }


                if (Equals(answer1, "0"))
                {
                    flag = false;
                }

            }



            Console.ReadKey();
        }
    }

}


