using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 2, 4, 7, 12 };
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
        }
    }
}
