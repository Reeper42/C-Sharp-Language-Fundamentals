using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameManager.Models
{
    public class VideoGame
    {
        public int GameId { get; set; }  //should all of these properties be auto initialized? Should some have more logic? 
        public string GameTitle { get; set; }
        public decimal GamePrice { get; set; }
        public List<PlatformID> GamePlatform { get; set; }//this is new to me, I'm unsure of how to go about this
        public int GameReleaseDate { get; set; }
        public List<VideoGame> GameList;

        public VideoGame()
        {
        }


    }
}
