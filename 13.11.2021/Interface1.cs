using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2021
{
    interface ICipher
    {
        string Encode(string str1);
        string Decode(string str2);

    }
}
