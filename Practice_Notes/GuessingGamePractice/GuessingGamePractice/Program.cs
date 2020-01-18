using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGamePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string input;
            int guess;

            Random rng = new Random();
            answer = rng.Next(1, 21);

            while (true)
            {
                Console.WriteLine("Enter a guess from 1 to 20: ");
                input = Console.ReadLine();

                if(input.TryParse(input, out guess));

                if (guess == answer)
                {
                    break;
                }
            }
        }
    }
}
