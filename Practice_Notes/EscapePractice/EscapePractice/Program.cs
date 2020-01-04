using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The cow says, \"MOO\""); // Slashes allow MOO to printed with ""
            //Console.WriteLine("1\t2\t3\t");
            //Console.WriteLine("1\n2\n3");
            //Console.WriteLine("c:\\Data\\MyFile.txt");

            //Console.WriteLine(@"c:\Data\MyFile.txt"); //this is a verbatim string
            Console.WriteLine(@"One
Two
Three"); //Also verbatim where the actuall spaces show without having to use slashes.
            Console.ReadLine(); 
        }
    }
}
