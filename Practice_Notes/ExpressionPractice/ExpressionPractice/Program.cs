using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 20;
            int result = Add(x, y);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

    }
}
