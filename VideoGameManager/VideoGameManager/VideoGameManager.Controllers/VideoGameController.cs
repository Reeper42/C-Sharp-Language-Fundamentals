using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManager.View;
using VideoGameManager.Models;
using VideoGameManager.Data;

namespace VideoGameManager.Controllers
{
    public class VideoGameController
    {
        public void Run()
        {
            var videoGameData = new VideoGameRepository(); 
            var videoGame = new VideoGameView();

            while (true)
            { 
    
                int userChoice = videoGame.GetMenuChoice();
                Console.WriteLine("You chose "+ userChoice);

                switch (userChoice)
                {
                    case 0:
                        return;
                    case 1:
                        VideoGame gameInfo = videoGame.GetNewVideoGameInfo();
                        videoGameData.Create(gameInfo);                                          
                        break;
                    case 2:
                        List<VideoGame> games = videoGameData.ReadAll();
                        videoGame.DisplayGameList(games);
                        break;
                    case 3:
                        var gameId = new VideoGameController();
                        gameId.SearchVideoGame();
                        break;
                    //case 4:
                    //    videogame editinfo = videogame.editvideogameinfo();
                    //    break;
                    //case 5:
                    //    videogame removegame = videogame.confirmremovevideogame();
                    //    break;

                }
            }
        }

        private void CreateVideoGame()
        {
            var videoGame = new VideoGame();         
            return;
        }

        private void DisplayVideoGame()
        {
            return;
        }

        private void SearchVideoGame()
        {
            while (true)
            {
                Console.WriteLine("Enter the ID of the game you would like to find. ");
                string userInput = Console.ReadLine();
                int gameId;
                if(int.TryParse(userInput, out gameId))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid ID");
                }
            }

            return;
        }

        private void EditVideoGame()
        {
            return;
        }

        private void RemoveVideoGame()
        {
            return;
        }
    }
}
