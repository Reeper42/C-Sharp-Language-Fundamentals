using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            string input;
            Console.Write("What is your Age? ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out userAge))
            {
                Console.WriteLine("Pleae give a valid input ");
                return;
            }
            
            int maxRate = (220 - userAge);
            Console.WriteLine("Your maximum heart rate should be "+maxRate+ " beats per minute");
            double zoneRate50 = (maxRate / 2);
            double zoneRate85 = (maxRate / (17 / 20)); //Assignment does not specify if the numbers must be ints.
            Console.WriteLine("Your target HR Zone is " + zoneRate50 + " - " + zoneRate85+ " beats per minute");
        }
    }
}
