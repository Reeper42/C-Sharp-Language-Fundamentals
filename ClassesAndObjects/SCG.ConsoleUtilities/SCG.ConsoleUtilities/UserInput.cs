using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCG.ConsoleUtilities
{
   public class UserInput
    {
        public int GetIntFromUser(string prompt)
        {
            string input;
            int output;

            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                    return output;

                Console.Write("That was not a valid integer... press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
