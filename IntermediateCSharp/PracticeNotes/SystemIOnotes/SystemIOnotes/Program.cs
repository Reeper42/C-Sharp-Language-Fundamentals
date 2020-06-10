using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIOnotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".\List.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            //string[] lines = new string[]
            //{
            //    "Blue","green","yellow","Red","orange"
            //};
            //File.WriteAllLines(path, lines); This is the WriteAllLines method

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Red");
                writer.WriteLine("green");
                writer.WriteLine("yellow");
                writer.WriteLine("blue");
            }

            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine("orange");
                writer.WriteLine("purple");
                writer.WriteLine("pink");
            }

            //string[] allLines = File.ReadAllLines(path);

            //foreach(string line in allLines)
            //{
            //    Console.WriteLine(line);
            //}

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
