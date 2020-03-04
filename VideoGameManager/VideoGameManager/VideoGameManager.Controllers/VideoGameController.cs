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
                        int searchGame = videoGame.SearchVideoGame();
                        VideoGame foundGame = videoGameData.ReadById(searchGame);
                        videoGame.DisplayVideoGame(foundGame);                  
                        break;
                    case 4:
                        int editGame = videoGame.GetGameId();
                        VideoGame newGameInfo = videoGame.GetOldVideoGameInfo(editGame);
                        videoGameData.Delete(editGame);
                        videoGameData.Create(newGameInfo);
                        break;
                    case 5:
                        int removeGame = videoGame.GetGameId();
                        videoGameData.Delete(removeGame);                      
                        break;

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
