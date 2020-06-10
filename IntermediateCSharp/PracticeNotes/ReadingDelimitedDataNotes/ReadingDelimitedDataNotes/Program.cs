using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingDelimitedDataNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\data\AddressBook.txt";
            if (File.Exists(path))
            {

            }
            else
            {
                Console.WriteLine("Could not find the file at {0}", path);
            }

            string[] rows = File.ReadAllLines(path);

            List<Contact> contacts = new List<Contact>();

            for (int i = 1; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(',');

                Contact c = new ReadingDelimitedDataNotes.Contact();
                c.FirstName = columns[0];
                c.LastName = columns[1];
                c.Street1 = columns[2];
                c.Street2 = columns[3];
                c.City = columns[4];
                c.State = columns[5];
                c.ZipCode = columns[6];

                contacts.Add(c);
            }

            foreach(var contact in contacts.OrderBy(c => c.LastName))
            {
                Console.WriteLine("{0}, {1}", contact.LastName, contact.FirstName);
                Console.WriteLine(contact.Street1);

                if (!string.IsNullOrEmpty(contact.Street2))
                    Console.WriteLine(contact.Street2);

                Console.WriteLine("{0}, {1} {2}", contact.City, contact.State, contact.ZipCode);

                Console.WriteLine("");
            }
        }
    }
}
