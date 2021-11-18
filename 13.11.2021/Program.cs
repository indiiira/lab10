using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Если хотите использовать шифр A нажмите 1, если шифр B нажмите 2, хотите выйти 0");
                int n;
                
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Введите целое число ");
                }
                    if (n == 1)
                    {


                        Console.WriteLine("Если хотите зашифровать строку нажмите 1, если дешифровать 2");
                        int n1;
                        while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0) ;
                        {
                            if (n1 == 1)
                            {
                                Console.WriteLine("Введите строку");
                                string str = Console.ReadLine();
                               
             
                                Console.WriteLine("Зашифрованная строка" + aCipher.Encode(str));
                            }
                            else if (n1 == 2)
                            {
                                Console.WriteLine("Введите строку");
                                string str = Console.ReadLine();
                              
                             
                                Console.WriteLine("Расшифрованная строка" + aCipher.Decode(str));
                            }
                        }
                    }

                    else if (n == 2)
                    {
                        Console.WriteLine("Если хотите зашифровать строку нажмите 1, если дешифровать 2");
                        int n1;
                        while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0) ;
                        {
                            if (n1 == 1)
                            {
                                Console.WriteLine("Введите строку");
                                string str = Console.ReadLine();
                               
                      
                                Console.WriteLine("Зашифрованная строка " + bCipher.Encode(str));
                            }
                            else if (n1 == 2)
                            {
                                Console.WriteLine("Введите строку");
                                string str = Console.ReadLine();
                               
                                Console.WriteLine("Расшифрованная строка " + bCipher.Encode(str));
                            }
                        }

                    }
                else if (n == 0)
                {
                    flag = false;
                }
            }


            Console.ReadKey();
        }

    }
}

