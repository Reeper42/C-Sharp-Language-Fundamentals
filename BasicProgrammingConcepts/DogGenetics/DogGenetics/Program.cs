using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random percent = new Random();
            string userDog;
            int breed1 = (percent.Next(26));
            int breed2 = (percent.Next(26));
            int breed3 = (percent.Next(26));
            int breed4 = (percent.Next(25));
            int breed5 = (100 - breed1 - breed2 - breed3 - breed4);
//I want to know if there is a way to set up an expression to get 5 random values between 0-100 and have them equal 100 every time.           

            Console.Write("What is your dog's name? ");
            userDog = Console.ReadLine();
            Console.WriteLine("Well then, I have this highly reliable report on " + userDog + "'s prestigious background right here. \n\n");
            Console.WriteLine(userDog + " is: \n\n");

            Console.WriteLine(breed1 + "% German Shepard");
            Console.WriteLine(breed2 + "% Golden Retriever");
            Console.WriteLine(breed3 + "% Beagle");
            Console.WriteLine(breed4 + "% Dashund");
            Console.WriteLine(breed5 + "% Boxer \n\n");
            Console.WriteLine("Wow, that's QUITE the dog!");
            
        }
    }
}
