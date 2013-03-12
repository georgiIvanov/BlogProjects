using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;
using StudentInitializers;

namespace StudentsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student().AddFirstName("Odisei"));
            students.Add(new Student().AddFirstName("Odikopai"));
            students.Add(new Student().AddFirstName("Apatrahil"));
            students.Add(new Student().AddFirstName("Ahil"));
            students.Add(new Student().AddFirstName("Ivan"));

            foreach (var item in students.GetNamesAfterChar('i'))
            {
                Console.WriteLine(item.FirstName);
            }

            
        }
    }
}
