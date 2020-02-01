using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrayNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 2, 0 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.WriteLine($"i={i}, current sum={sum}");
            }

            Console.WriteLine($"Final sum: {sum}");
        }
    }
}
