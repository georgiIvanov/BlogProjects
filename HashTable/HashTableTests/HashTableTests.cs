﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashImplementation;

namespace HashTableTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void CreateDefaultConstructor()
        {
            HashTable<string, string> hashTable = new HashTable<string, string>();
            Assert.AreEqual(0, hashTable.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateWithNegativeCapacity()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateWithZeroCapacity()
        {
            HashTable<int, string> hashTable = new HashTable<int, string>(0);
        }
    }
}
