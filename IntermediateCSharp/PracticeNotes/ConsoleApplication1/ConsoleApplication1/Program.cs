using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstName = "Daniel";
            string lastName = "Reep";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "JOhn", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            var text = "Hi John \nLook into the following paths \n c:\\folder1\\2";
            Console.WriteLine(text);
        }
    }
}
