using System;
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
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("0:Exit  1:Create  2:List All  3:Find By Id  4:Edit 5:Remove ");
            string userInput = Console.ReadLine();
            int userChoice;

            if (int.TryParse(userInput, out userChoice))
            {
                ;
            }
            else
            {
                Console.WriteLine("Please choose a valid option. ");
            }
            return userChoice;
        }

        public VideoGame GetNewVideoGameInfo()
        {
            string userInput;
            string title;          
            int id;
            decimal price;
            int releaseDate;

            VideoGame game = new VideoGame();

            Console.Write("Game id: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out id))
            {
                ;
            }
            else
            {
                Console.WriteLine("That is not a valid id.");
            }
            game.GameId = id;

            Console.Write("Game Title: ");
            title = Console.ReadLine();
            game.GameTitle = title;

            Console.Write("Game Price: ");
            userInput = Console.ReadLine();
            if (decimal.TryParse(userInput, out price))
            {
                ;
            }
            else
            {
                Console.WriteLine("That is not a valid price! ");
            }
            game.GamePrice = price;

            Console.Write("Game's Release Date: ");
            userInput = Console.ReadLine();
            if(int.TryParse(userInput, out releaseDate))
            {
                ;
            }
            else
            {
                Console.WriteLine("That is not a valid date! ");
            }
            game.GameReleaseDate = releaseDate;
                
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
            
            return;
        }

        public VideoGame EditVideoGameInfo(VideoGame videoGame)
        {
            return null;
        }

        public int SearchVideoGame()
        {
            return 0;
        }

        public bool ConfirmRemoveVideoGame(VideoGame videoGame)
        {
            return false;
        }

    }
}
