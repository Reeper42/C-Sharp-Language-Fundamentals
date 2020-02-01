using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {



            int x = 5;
            int y = 10;
            Calculator c = new Calculator();
            int sum = c.Add(x, y); //Not sure why I'm getting this error
        }
    }
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}

