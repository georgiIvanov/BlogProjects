using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void RemoveOneEntry()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(10, name);

            string searching = name + 0;
            bool removeResult = hashTable.Remove(searching.GetHashCode());

            Assert.AreEqual(true, removeResult);
            Assert.AreEqual(9, hashTable.Count);
        }

        [TestMethod]
        public void Remove100()
        {
            string name = "Haralampi";
            HashTable<int, string> hashTable = Utilities.AddEntries(300, name);

            bool removeResult = true;

            for (int i = 0; i < 100 && removeResult; i++)
            {
                string searching = name + i;
                removeResult = hashTable.Remove(searching.GetHashCode());
            }

            Assert.AreEqual(true, removeResult);
            Assert.AreEqual(200, hashTable.Count);
        }
    }
}
