using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashImplementation;

namespace HashTableTests
{
    public class Utilities
    {
        public static HashTable<int, string> AddEntries(int count, string name) 
        {
            HashTable<int, string> hashTable = new HashTable<int, string>(count);

            for (int i = 0; i < count; i++)
            {
                string entryName = name + i;
                hashTable.Add(entryName.GetHashCode(), entryName);
            }
            return hashTable;
        }
    }
}
