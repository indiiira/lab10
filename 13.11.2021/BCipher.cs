using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2021
{
    class BCipher
    {
        //символы русской азбуки
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        const string malfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
       
      
        public string Encode(string text)
        {
            

            var retVal = "";
    
            for (int i = 0; i < text.Length; i++)
            {
                string t = Convert.ToString(text[i]);
                if (alfabet.IndexOf(text[i]) >= 0)
                {
                    var c = text[i];
                    var index = alfabet.IndexOf(c);
                    var b = Math.Abs(32 - alfabet.IndexOf(c));
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = b;
                        retVal += alfabet[codeIndex];
                    }
                }
                else if (malfabet.IndexOf(text[i]) >= 0)
                {
                    var c = text[i];
                    var index = malfabet.IndexOf(c);
                    var b = Math.Abs(32 - malfabet.IndexOf(c));
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = b;
                        retVal += malfabet[codeIndex];
                    }
                }
                else if (t== " ")
                {
                    retVal += " ";
                }

            }

            return retVal;
        }
        
        }
    }

       



