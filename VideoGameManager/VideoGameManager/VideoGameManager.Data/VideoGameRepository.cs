using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManager.Models;

namespace VideoGameManager.Data
{
    public class VideoGameRepository
    {
        List<VideoGame> games = new List<VideoGame>();
        

        public VideoGame Create(VideoGame videoGame)
        {
            games.Add(videoGame);
            return videoGame;
        }

        public List<VideoGame> ReadAll()
        {
            return games;
        }

        public VideoGame ReadById(int id)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GameId == id)
                    return games[i];
            }
            return null;
        }

        public void Update(int id, VideoGame videoGame)
        {
            return;
        }

        public void Delete(int id)
        {
            games.RemoveAll(x => x.GameId == id);
            return;
        }
    }
}
