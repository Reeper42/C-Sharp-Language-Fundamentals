using System;

namespace StructsNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayOfWeekAndYear();
            //DifferenceofDates();
            //if(DateTime.Today.Month == 1 && DateTime.Today.Day == 1)
            //{
            //    Console.WriteLine("Happy New Year!");
            //}
            //else
            //{
            //    DateTime nextNewYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            //    TimeSpan daysUntilNewYears = nextNewYear - DateTime.Today;
            //    Console.WriteLine("There are {0} days until New Years" , daysUntilNewYears.Days);
            //}
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //DateTime d1 = DateTime.Parse("3/12/2020");
            //Console.WriteLine(d1.Year);
            //Console.WriteLine(d1.Day);
            //Console.WriteLine("{0} is {1} days into the calender year", d1, d1.DayOfYear);
            //new DateTime(2020, 3, 12, 18, 40, 0); //Can't use time without seconds.
            //Console.WriteLine("Enter a date: ");
            //string input = Console.ReadLine();

            //DateTime date;

            //if(DateTime.TryParse(input, out date))
            //{
            //    Console.WriteLine("{0} is a valid date", date);
            //}
        }

        static void DifferenceofDates()
        {
            DateTime newYears = new DateTime(DateTime.Today.Year + 1, 1, 1);// year,month, day

            DateTime now = DateTime.Today;

            TimeSpan timeUntilNewYears = newYears.Subtract(now);
            Console.WriteLine("It is {0} days until new years, ", timeUntilNewYears.Days);

            //DateTime lastDayofMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month);
        }
        //static void CreateDateTimeObjects()
        //{
        //    DateTime onlyDate = DateTime.Today;

        //    DateTime aDate = new DateTime();
        //    DateTime specificDate = new DateTime(1995, 6, 10);

        //    string input = Console.ReadLine();
        //    DateTime userDate;
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a Date: ");
                

        //        if(DateTime.TryParse(input, out userDate))
        //        {
        //            break;
        //        }
        //        Console.WriteLine();
         

        //public struct Coordinate
        //{
            //public int X = 5;
            //public int Y = 10; Cannot have initializers in structs.

            //public int X { get; set; }
            //public int Y { get; set; }

            //public Coordinate()
            //{
            //Structs are given a parameterless constructor, therefore I cannot make my own.
            //}
            //public Coordinate(int x, int y)
            //{
            //    X = x;
            //    Y = y;
            //}

        static void DayOfWeekAndYear()
        {
            DateTime nextIndependence = new DateTime(DateTime.Today.Year + 1, 7, 4);

            switch (nextIndependence.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("{0:d} is on the weekend", nextIndependence);
                    break;
                default:
                    Console.WriteLine("{0:d} is on a weekday", nextIndependence);
                    break;

            }

            Console.WriteLine("{0:d} is on the {1} day of the year", nextIndependence, nextIndependence.DayOfYear);
        }
        static void ManipulatingDateValues()
        {
            DateTime now = DateTime.Now;

            DateTime dueDate = now.AddDays(30).AddHours(5);
            TimeSpan ts = new TimeSpan(30, 5, 0, 0);
            DateTime due = dueDate.Add(ts);

            DateTime pastDate = now.AddDays(-5);
        }

    }
}
