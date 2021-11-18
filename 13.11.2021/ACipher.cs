using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2021
{
    public class ACipher : ICipher
    {
      
    
            public string Encode(string str1)
        {

            string ciphertext = " ";
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1 == "Я")
                    ciphertext = ciphertext + "А";
                else
                    ciphertext = ciphertext + (char)(str1[i] + 1);
            }
            return ciphertext;
        }
        public string Decode(string str2)
        {
            string deciphertext = " ";
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2 == "А")
                
                    deciphertext = deciphertext + "Я";

                else
                    deciphertext = deciphertext + (char)(str2[i] - 1);
                
            }
            return deciphertext;
        }
    }
}