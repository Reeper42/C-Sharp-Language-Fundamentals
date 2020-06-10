using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int output;

            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Enter a number (Q to quit): ");
                input = Console.ReadLine();
                if(int.TryParse(input, out output))
                {
                    numbers.Add(output);
                }
            } while (input != "Q");

            Console.WriteLine("the numbers entered were: {0}", string.Join(",", numbers));

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the numbers is: {0}", sum);

            numbers.Remove(5);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            {

            }
        }

        public class Product
        {
            public string UPCCode { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }

            Dictionary<string, Product> products = new Dictionary<string, Product>();
        }
    }
}
