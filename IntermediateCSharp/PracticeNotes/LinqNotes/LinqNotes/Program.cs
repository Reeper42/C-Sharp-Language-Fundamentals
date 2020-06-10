using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> allNumbers = new List<int>()
            //{ 4,2,3,7,15,20,6};

            //List<int> onlyOdds = new List<int>();

            //foreach (int number in allNumbers)
            //{
            //    if (number % 2 == 1)
            //        onlyOdds.Add(number);
            //}

            List<int> allNumbers = new List<int>()
            { 4,2,3,7,15,20,6};

            //var onlyOdds = from number in allNumbers
            //               where number % 2 == 1
            //               select number;
            //var onlyOdds = allNumbers.Where(number => number % 2 == 1);
            IEnumerable<int> onlyOdds = allNumbers.Where(number => number % 2 == 1);  //Not sure what the problem is. Is number not a variable?

            List<int> methodSyntax = allNumbers.Where(number => number % 2 == 1).ToList();
            List<int> querySyntax = (from number in allNumbers
                                     where number % 2 == 1
                                     select number).ToList();

            int howManyOdds = onlyOdds.Count();
            int biggestOdd = onlyOdds.Max();
        }
    }
}
