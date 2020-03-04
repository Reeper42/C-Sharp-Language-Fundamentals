using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManager.Controllers;

namespace VideoGameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new VideoGameController();
            menu.Run();
        }
    }
}
