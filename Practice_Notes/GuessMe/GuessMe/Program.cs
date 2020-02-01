using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string input;
            int guess;

            Console.WriteLine("I've chosen a number. Betcha can't guess it!");
            input = Console.ReadLine();
            answer = 42;

            if(int.TryParse(input, out guess)) // is this the only way to convert input to an int?

            

            if (guess == answer)
            {
                    Console.WriteLine("Wow, nice guess! That was it!");
            }
            if (guess < answer)
            {
                Console.WriteLine("Ha, nice try - too low! I chose 42");
            }
            if (guess > answer)
            {
                Console.WriteLine("Toobad, way too high. I chose 42");
            }
        }
    }
}
