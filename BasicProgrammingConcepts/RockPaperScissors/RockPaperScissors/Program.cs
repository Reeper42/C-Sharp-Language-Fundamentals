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
            int userInput = 0;

            while(true)
            {
                Console.WriteLine("How many rounds do you want to play? (choose between 1-10)  ");
                string userChoice = Console.ReadLine();

                if( int.TryParse(userChoice, out Rounds))
                {
                    if(Rounds < 0 || Rounds > 10)
                    {
                        Console.WriteLine("That number is out of bounds ");
                        break;
                        //not sure how to exit program here.
                    }


                    while (Rounds > 0)
                    {
                        Console.WriteLine("Choose between 1=Rock, 2=Paper, or 3=Scissors  ");
                        string Input = Console.ReadLine();
                        if (!int.TryParse(Input, out userInput))
                        {
                            Console.WriteLine("Please enter a valid number. ");
                            continue;
                        }
                        Random rng = new Random();
                        int Random = rng.Next(1, 4);

                        if (userInput == Random)
                        {
                            Console.WriteLine("The round is a tie!  ");
                            Ties++;
                            Rounds--;
                            continue;
                        }
                        else if(userInput==1 && Random == 2)
                        {
                            Console.WriteLine("Computer Wins!  ");
                            computerWins++;
                            Rounds--;
                            continue;
                        }
                        else if (userInput == 1 && Random == 3)
                        {
                            Console.WriteLine("You Win!  ");
                            userWins++;
                            Rounds--;
                            continue;
                        }
                        else if (userInput == 2 && Random == 3)
                        {
                            Console.WriteLine("Computer Wins!  ");
                            computerWins++;
                            Rounds--;
                            continue;
                        }
                        else if (userInput == 2 && Random == 1)
                        {
                            Console.WriteLine("You Win!  ");
                            userWins++;
                            Rounds--;
                            continue;
                        }
                        else if (userInput == 3 && Random == 1)
                        {
                            Console.WriteLine("Computer Wins!  ");
                            computerWins++;
                            Rounds--;
                            continue;
                        }
                        else if (userInput == 3 && Random == 2)
                        {
                            Console.WriteLine("You Win!  ");
                            userWins++;
                            Rounds--;
                            continue;
                        }
                    }

                    Console.WriteLine("Ties: " + Ties + " Your Wins: " + userWins + " Computer Wins: " + computerWins );
                    if (userWins > computerWins)
                    {
                        Console.WriteLine("You are the winner!");
                    }
                    else
                    {
                        Console.WriteLine("Computer Wins! ");
                    }
                }

                Console.WriteLine("Would you like to play again? y/n  ");
                string playAgain = Console.ReadLine();
                if (playAgain.ToUpper() == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing! ");
                    break;
                }

            } //This is the bare minimum of what the assginments wants me to do.
            // There is no result for if we tie. The assginment does not specify if the number of wins are suppose to reset. It also does not ask me to display what the computer chose.
            // Code is still very messy. Wonder if would be better to use a switch statement then present cases of the out come.


        }
    }
}
