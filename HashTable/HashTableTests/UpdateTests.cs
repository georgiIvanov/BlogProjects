using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class UpdateTests
    {
        [TestMethod]
        public void UpdateSingleEntry()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(1, name);

            string searching = name + 0;
            hashTable[searching.GetHashCode()] = "Ala-bala";

            string actual = hashTable[searching.GetHashCode()];

            Assert.AreEqual("Ala-bala", actual);
        }

        [TestMethod]
        public void UpdateManyEntries()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(5000, name);

            string searching = name + 1500;
            hashTable[searching.GetHashCode()] = "Ala-bala";

            string actual = hashTable[searching.GetHashCode()];

            Assert.AreEqual("Ala-bala", actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateNonExisting()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(100, name);

            string searching = name + 1500;

            string actual = hashTable[searching.GetHashCode()];
        }


    }
}
