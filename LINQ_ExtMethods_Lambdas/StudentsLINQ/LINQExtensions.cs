using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;

namespace StudentsLINQ
{
    public static class LINQExtensions
    {
        public static IEnumerable<Student> GetNamesAfterChar(this IEnumerable<Student> students, char ch)
        {
            foreach (var stud in students)
            {
                if (stud.FirstName.ToLower()[0] > ch)
                {
                    yield return stud;
                }
            }
        }
    }
}
