using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityandAssignmentPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // assignment operator is "="
            // int x, y;
            //x = 5;
            //y = x;

            // equality operator == "equal to"
            //int x, y;
            //x = 5;
            //y = 3;

            //Console.WriteLine(x == y);

            // Object 1
            Person p1 = new Person();
            p1.Name = "Daneil";
            // object 2
            //Person p2 = new Person();
            //p2.Name = "Daniel";

            // The reason They are false is because they are reference types
            //This means they have different spaces in Memory

            Person p2 = p1;
            //This ways is one object with two variables pointing to it.

            Console.Write(p1 == p2);
            Console.ReadLine();

        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
