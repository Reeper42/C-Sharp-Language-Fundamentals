using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 10;

            //// false, will not execute Console.WriteLine() statement
            //// only one statement, so { } not needed
            //if (x > y)
            //    Console.WriteLine("x is bigger");

            //// true, will execute Console.WriteLine() statements
            //if (x < y)
            //{
            //    Console.WriteLine("x is smaller");
            //    Console.WriteLine("y is bigger");
            //if (x > y)
            //    Console.WriteLine("x is bigger");  //no {} because there is only one statement.
            //else
            //    Console.WriteLine("Y is bigger");
            //if (x < 20 && y < 20)
            //{
            //    Console.WriteLine("Both values < 20");
            //}
            //else if (x < 15 && y < 15)
            //{
            //    Console.WriteLine("Both values < 15");
            //}
            //else if (x < 10 && y < 10)
            //{
            //    Console.WriteLine("Both values < 10");
            //}
            //else
            //{
            //    Console.WriteLine("None of the above");
            //}

            int x = 4;

            switch (x)
            {
                // single case
                case 0:
                    Console.WriteLine("x is 0");
                    break;
                // multiple cases, aka "fall through"
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("x is 1, 2, or 3");
                    break;
                default:
                    Console.WriteLine("x is not 0, 1, 2, or 3");
                    break;
            }


        }
      }
    }
