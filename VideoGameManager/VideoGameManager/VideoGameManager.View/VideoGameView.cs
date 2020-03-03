﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManager.Models;


namespace VideoGameManager.View
{
    public class VideoGameView
    {
        public int GetMenuChoice()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("0:Exit  1:Create  2:List All  3:Find By Id  4:Edit 5:Remove ");
                string userInput = Console.ReadLine();
                int userChoice;
                if (int.TryParse(userInput, out userChoice))
                {
                    return userChoice;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option. ");
                }
                
            }

        }

        public VideoGame GetNewVideoGameInfo()
        {
            string userInput;
            string title;          
            int id;
            decimal price;
            int releaseDate;

            VideoGame game = new VideoGame();

            while (true)
            {
                Console.Write("Game id: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out id))
                {
                    game.GameId = id; 
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid id.");
                }
                                            
            }


            Console.Write("Game Title: ");
            title = Console.ReadLine();
            game.GameTitle = title;

            while (true)
            {
                Console.Write("Game Price: $");
                userInput = Console.ReadLine();
                if (decimal.TryParse(userInput, out price))
                {
                    game.GamePrice = price;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid price! ");
                }
                                
            }

            while (true)
            {
                Console.Write("Game's Release Date: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out releaseDate))
                {
                    game.GameReleaseDate = releaseDate;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid date! ");
                }
                                
            }
            return game;
        }

        public void DisplayGameList(List<VideoGame> gameList)
        {
            for (int i = 0; i < gameList.Count; i++)
            {
                DisplayVideoGame(gameList[i]);
            }
        }

        public void DisplayVideoGame(VideoGame videoGame)
        {
            Console.WriteLine("Game:  "+ videoGame.GameTitle);
            Console.WriteLine("ID: "+ videoGame.GameId);
            Console.WriteLine("Price: $"+ videoGame.GamePrice);
            Console.WriteLine("Year: "+ videoGame.GameReleaseDate);
            return;
        }

        public VideoGame EditVideoGameInfo(VideoGame videoGame)
        {
            return null;
        }

        public int SearchVideoGame()
        {
            int gameId;
            while (true)
            {
                Console.WriteLine("Enter the ID of the game you would like to find. ");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out gameId))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid ID");
                }
            }
            return gameId;
        }

        public int ConfirmRemoveVideoGame()
        {
            while (true)
            {
                Console.WriteLine("Enter the Id of the game you would like to delete.  ");
                string userInput = Console.ReadLine();
                int id;
                if (int.TryParse(userInput, out id))
                {
                    return id;
                }
                else
                {
                    Console.WriteLine("That is not a valid ID. ");                   
                }
            }            
        }

    }
}