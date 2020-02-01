using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMeFinally
{
    class Program
    {
        static void Main(string[] args)// how do i count how many times a user goes through the loop?
        {
            int answer;
            string input;
            int guess;
            int timesGuessed = 0;

            Random rng = new Random();
            answer = rng.Next(1, 101);

            while (true)
            {
                Console.WriteLine("Im thinking of a number between 1 and 100. Can you guess it?");
                input = Console.ReadLine();

                if(int.TryParse(input, out guess)) // how would i prompt the user with a message saying that is an invalid answer if they answered something other than an int?
                {
                    if (guess == answer)
                    {
                        break;
                    }

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("That is guess is not in bounds...Try Again! Remember between 1 and 100");
                        timesGuessed++;
                        continue;
                    }
                    if (guess < answer)
                    {
                        Console.WriteLine("Nope, That's too low! Try again.");
                        timesGuessed++;
                        continue;
                    }
                    if (guess > answer)
                    {
                        Console.WriteLine("Nope, Thats too HIGH! Try again.");
                        timesGuessed++;
                        //continue; REMEMBER don't need continue if it is at the end of the loop.
                    }
                }
            }
            if(timesGuessed < 1)
            {
                Console.WriteLine("Wow, nice guess! That was it!");
            }
            if (timesGuessed >= 1)
            {
                Console.WriteLine("Finally, It's about time you got it!");
            }
            
        }
    }
}
