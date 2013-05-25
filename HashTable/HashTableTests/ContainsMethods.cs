using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class ContainsMethods
    {
        [TestMethod]
        public void ContainsKey()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(100, "Haralampi");
            string searchingFor = "Haralampi" + 55;

            var result = hashTable.ContainsKey(searchingFor.GetHashCode());
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsValue()
        {
            HashTable<int, string> hashTable = Utilities.AddEntries(100, "Haralampi");
            string searchingFor = "Haralampi" + 55;

            var result = hashTable.ContainsValue(searchingFor);
            Assert.IsTrue(result);
        }
    }
}
