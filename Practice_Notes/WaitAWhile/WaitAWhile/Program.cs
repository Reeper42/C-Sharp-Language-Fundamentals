using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeNow = 5; // If I Change timeNow's value to 11 then the while loop would be skipped and the last Console.WriteLine's would exe. and the program would end.
            int bedTime = 10;  // If I change bedTime's value to 11 then It wold continue the while loop until timeNow's value becomes 11 then program would exit the loop and end

            while (timeNow < bedTime)
            {
                Console.WriteLine("It's only " + timeNow + " o'clock!");
                Console.WriteLine("I think I'll stay up just a liiiiiiitle longer....");
                timeNow++; //time passes
            }

            Console.WriteLine("Oh. It's " + timeNow + " o'clock.");
            Console.WriteLine("Guess I should go to bed...");
        }
    }
}
