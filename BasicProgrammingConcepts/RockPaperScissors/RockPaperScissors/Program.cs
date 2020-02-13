using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rounds = 0;
            int Rock = 1;
            int Paper = 2;
            int Scissors = 3;
            int Ties = 0;
            int userWins = 0;
            int computerWins = 0;

            while(true)
            {
                Console.WriteLine("How many times do you want to play?  ");
                string userInput = Console.ReadLine();

                if( int.TryParse(userInput, out Rounds))
                {
                    if(Rounds < 0 || Rounds > 10)
                    {
                        Console.WriteLine("That number is out of bounds ");
                    }
                }


            }


        }
    }
}
