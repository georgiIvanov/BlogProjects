using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class AddMethod
    {
        [TestMethod]
        public void AddOne()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(1, "Haralampi");

            Assert.AreEqual(1, hashTable.Count);
        }

        [TestMethod]
        public void AddTen()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(10, "Haralampi");

            Assert.AreEqual(10, hashTable.Count);
        }

        [TestMethod]
        public void AddThousand()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(1000, "Haralampi");

            Assert.AreEqual(1000, hashTable.Count);
        }

        [TestMethod]
        public void AddTenThousand()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(10000, "Haralampi");

            Assert.AreEqual(10000, hashTable.Count);
        }

        

    }
}
