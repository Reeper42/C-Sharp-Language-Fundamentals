﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StillPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 389, -447, 26, -485, 712, -884, 94, -64, 868, -776, 227, -744, 422, -109, 259, -500, 278, -219, 799, -311 };

            Console.WriteLine("Gotta stay positive...!");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write($"{numbers[i]} "); //I would like to discuss other approaches of completeing this task.
                    continue;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
