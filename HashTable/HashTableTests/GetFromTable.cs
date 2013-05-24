using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class GetFromTable
    {
        [TestMethod]
        public void TryGetValue()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(10, name);

            string result = string.Empty;
            string searching = name + 9;

            bool getValueResult = hashTable.TryGetValue(searching.GetHashCode(), out result);

            Assert.IsTrue(getValueResult);

            Assert.AreEqual(searching, result);
        }

        [TestMethod]
        public void TryGetValueFalse()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(10, name);

            string result = string.Empty;
            string searching = name + 10;

            bool getValueResult = hashTable.TryGetValue(searching.GetHashCode(), out result);

            Assert.IsFalse(getValueResult);

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TryGetManyEntries()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(100000, name);

            string result = string.Empty;
            string searching = name + 50000;

            bool getValueResult = hashTable.TryGetValue(searching.GetHashCode(), out result);

            Assert.IsTrue(getValueResult);

            Assert.AreEqual(searching, result);
        }

        [TestMethod]
        public void GetWithIndexer()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(500, name);

            string result = string.Empty;
            string searching = name + 100;

            result = hashTable[searching.GetHashCode()];

            Assert.AreEqual(searching, result);
        }

        //[TestMethod]
        //public void DictionarySpeedTest1mEntries()
        //{
        //    Dictionary<int, string> dict = new Dictionary<int, string>();
        //    string name = "Haralampi";

        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        string entryName = name + i;
        //        dict.Add(entryName.GetHashCode(), entryName);
        //    }

        //    string searching = name + 650000;
        //    string result = string.Empty;
        //    dict.TryGetValue(searching.GetHashCode(), out result);
        //    Assert.AreEqual(searching, result);
        //}
    }
}
