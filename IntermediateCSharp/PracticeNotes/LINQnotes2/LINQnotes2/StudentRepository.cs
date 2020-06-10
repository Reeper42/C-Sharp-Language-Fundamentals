using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQnotes2
{
    public class StudentRepository
    {
        public static List<Student> SelectAll()
        {
            return new List<Student>
            {
                new Student {FirstName="Joe", LastName="Smtih", Major="Computer Science", GPA=3.5M },
                new Student {FirstName="Mary",LastName="Smith", Major="Business",GPA=3.0M },
                new Student {FirstName="Jane",LastName="Doe", Major="Computer Science",GPA=4.0M },
                new Student {FirstName="Bobby",LastName="Tables",Major="English",GPA=2.7M },
                new Student {FirstName="Rhonda",LastName="Miller",Major="English",GPA=3.8M },
                new Student {FirstName="Warren",LastName="Poole",Major="Theater",GPA=2.3M },
            };
        }
    }
}
