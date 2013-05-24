using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashImplementation;
using HashTableTests;

namespace HashTableProfiling
{

    /// <summary>
    /// Used only for profiling
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Haralampi";
            HashTable<int, string> hashtable = Utilities.AddEntries(1000000, name);

            string result = string.Empty;
            string searching = name + 50000;

            bool getValueResult = hashtable.TryGetValue(searching.GetHashCode(), out result);
        }
    }
}
