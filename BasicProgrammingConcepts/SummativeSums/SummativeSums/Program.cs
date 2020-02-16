using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Array1();
            int sum2 = Array2();
            int sum3 = Array3();
            Console.WriteLine("#1 Array Sum: " + sum1);
            Console.WriteLine("#2 Array Sum: " + sum2);
            Console.WriteLine("#3 Array Sum: " + sum3);

        }

        static int Array1()
        {
            int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int sum1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }
            return sum1;
        }
        static int Array2()
        {
            int[] array2 = { 999, -60, -77, 14, 160, 301 };
            int sum2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }
            return sum2;
        }
        static int Array3()
        {
            int[] array3 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
        140, 150, 160, 170, 180, 190, 200, -99 };
            int sum3 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                sum3 += array3[i];
            }
            return sum3;
        }
    }
}
