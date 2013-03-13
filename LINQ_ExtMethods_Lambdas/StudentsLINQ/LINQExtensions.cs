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

        public static IEnumerable<T> LexicographicallyBigger<T>(this IEnumerable<T> objects, char ch, Func<T, string> predicate)
        {
            foreach (var item in objects)
            {
                if (predicate(item).ToLower()[0] > ch)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> ThisWillHurt<T, DateTime>(this IEnumerable<T> objects, char ch, DateTime date, Func<T, DateTime, string> predicate)
        {
            foreach (var item in objects)
            {
                if (predicate(item, date).ToLower()[0] > ch)
                {
                    yield return item;
                }
            }
        }
    }
}
