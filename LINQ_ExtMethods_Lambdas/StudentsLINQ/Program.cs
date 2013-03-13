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
            Console.WriteLine();

            ///====================================================
            ///Lambdas 
            ///====================================================
            foreach (var item in students.LexicographicallyBigger('i', x => x.FirstName))
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();


            string[] veryImportantData = {"icecream", "cakes", "honey", "sweets", "rakiq" };

            foreach (var item in veryImportantData.LexicographicallyBigger('e', x => x))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //another way to write the query, produces same result,
            //but the query stays in stack memory
            IEnumerable<string> query = from data in veryImportantData
                                        .LexicographicallyBigger('e', x => x)
                                        select data;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //Complete nonsense from here on
            IEnumerable<Student> notPersistantQuery = students.ThisWillHurt('i', DateTime.Now,
                (x, date) => {
                    if ((date.Minute & 1) == 0)
                    {
                        return x.FirstName;
                    }
                    else
                        return x.FirstName[1].ToString();
                });

            foreach (var item in notPersistantQuery)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
