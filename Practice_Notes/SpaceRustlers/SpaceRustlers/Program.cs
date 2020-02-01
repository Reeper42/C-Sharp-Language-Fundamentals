using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRustlers
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceships = 10;
            int aliens = 25;
            int cows = 100;

            if (aliens > spaceships)// The if statements evaluates the expression then executes if true. If false the if statement allows the code to branch to an else statement and evaluate that expression.
            {
                Console.WriteLine("Vrroom, vroom! Let's get going!");
            }
            else
            {
                Console.WriteLine("There aren't enough green guys to drive these ships!");
            }

            if (cows == spaceships)
            {
                Console.WriteLine("Wow, way to plan ahead! JUST enough room for all these walking hamburgers!");
            }
            else if (cows > spaceships) // the else if statement allows us to evaluate multiple conditions and executes the first one that evaluates to true.
                // If I remove the else from the statement, then it still gets evaluated but not as part of the last if statement. 
            {
                Console.WriteLine("Dangit! I don't how we're going to fit all these cows in here!");
            }
            else
            {
                Console.WriteLine("Too many ships! Not enough cows.");
            }

            if (aliens > cows)
            {
                Console.WriteLine("Hurrah, we've got the grub! Hamburger party on AlphaCentauri!");
            }
            else if (cows >= aliens)
            {
                Console.WriteLine("Oh no! The herds got restless and took over! Looks like _we're_ hamburger now!!");
            }
        }
    }
}
