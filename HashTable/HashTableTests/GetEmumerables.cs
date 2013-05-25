using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;
using System.Linq;

namespace HashTableTests
{
    [TestClass]
    public class GetEmumerables
    {
        [TestMethod]
        public void GetFewKeyEnumerables()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(10, name);

            string result = string.Empty;
            

            var collectionResult = hashTable.Keys;

            Assert.AreEqual(10, collectionResult.Count());
        }

        [TestMethod]
        public void GetManyKeyEnumerables()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(100000, name);

            string result = string.Empty;


            var collectionResult = hashTable.Keys;

            Assert.AreEqual(100000, collectionResult.Count());
        }

        [TestMethod]
        public void GetFewValueEnumerables()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(10, name);

            string result = string.Empty;


            var collectionResult = hashTable.Values;

            Assert.AreEqual(10, collectionResult.Count());
        }

        [TestMethod]
        public void GetManyValueEnumerables()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(100000, name);

            string result = string.Empty;

            var collectionResult = hashTable.Values;

            Assert.AreEqual(100000, collectionResult.Count());
        }
    }
}
