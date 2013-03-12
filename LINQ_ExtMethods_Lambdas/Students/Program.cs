using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInitializers;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("foo", "fooEvich", "fooEvski",
                "lalaLand", 69, 911, "blooeweewew@kmal.com", 
                "Obushtarstvo i tehnologii v ezoterichnata promishlenost",
                Specialty.Cleaner);
                
            Console.WriteLine(stud.ToString());
        }
    }
}
    