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
            var videoGameLibrary = new VideoGameRepository(); 
            var mainMenu = new VideoGameView();

            while (true)
            { 
    
                int userChoice = mainMenu.GetMenuChoice();
                Console.WriteLine("You chose option: "+ userChoice);

                switch (userChoice)
                {
                    case 0:
                        return;
                    case 1:
                        VideoGame gameInfo = mainMenu.GetNewVideoGameInfo();
                        videoGameLibrary.Create(gameInfo);                                          
                        break;
                    case 2:
                        List<VideoGame> games = videoGameLibrary.ListAll();
                        mainMenu.DisplayGameList(games);
                        break;
                    case 3:
                        int searchGame = mainMenu.SearchVideoGame();
                        VideoGame foundGame = videoGameLibrary.ListById(searchGame);
                        mainMenu.DisplayVideoGame(foundGame);                  
                        break;
                    case 4:
                        int editGame = mainMenu.GetGameId();
                        VideoGame newGameInfo = mainMenu.GetOldVideoGameInfo(editGame);
                        videoGameLibrary.Delete(editGame);
                        videoGameLibrary.Create(newGameInfo);
                        break;
                    case 5:
                        int removeGame = mainMenu.GetGameId();
                        videoGameLibrary.Delete(removeGame);                      
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
