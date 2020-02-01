using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I like cheese";

            for (int i = 0; i < str.Length; i++)
            {
                switch(str[i])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        Console.Write(str[i]);
                        break;
                }
            }
        }
    }
}
