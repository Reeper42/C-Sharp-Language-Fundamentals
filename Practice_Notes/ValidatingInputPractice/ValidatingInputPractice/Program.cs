using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatingInputPractice
{
    class Program
    {
        //Demonstrate the need for validation of human input
        // Parse vs TryParse
        // looping to force valid input
        static void Main(string[] args)
        {
            
            //= int.Parse(input);

            while(true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                int number;

                if(int.TryParse(input, out number))
                {
                    number++;
                    Console.WriteLine("The number plus one is: {0}", number);
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid number!");
                }
            }

        }
    }
}
