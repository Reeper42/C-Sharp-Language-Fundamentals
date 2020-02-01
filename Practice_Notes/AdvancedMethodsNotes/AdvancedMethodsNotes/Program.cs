using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMethodsNotes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Circle
        {
            public static decimal PI = 3.14M;

            public decimal Radius;

            public decimal GetArea()
            {
                return PI * Radius * Radius;
            }
        }
    }
}
