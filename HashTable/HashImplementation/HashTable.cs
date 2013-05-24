using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashImplementation
{
    public class HashTable<K, V>
    {
        const double fillFactor = 0.75d;
        int maxItemsAtCurrentSize, 
            count;
        HashTableArray<K, V> array;

        public HashTable()
            :this(1000)
        {

        }

        public HashTable(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentException("Invalid initial capacity.");
            }

            array = new HashTableArray<K, V>(initialCapacity);
            maxItemsAtCurrentSize = (int)(initialCapacity * fillFactor) + 1;
        }

        public void Add(K key, V value)
        {
            if (count >= maxItemsAtCurrentSize)
            {
                GrowArray();
            }

            array.Add(key, value);
            count++;
        }

        public bool Remove(K key)
        {
            if (array.Remove(key))
            {
                count--;
                return true;
            }
            return false;
        }

        public V this[K key]
        {
            get
            {
                V value;
                if (!array.TryGetValue(key, out value))
                {
                    throw new ArgumentException("Invalid key");
                }
                return value;
            }
            set
            {
                array.Update(key, value);
            }
        }

        public bool TryGetValue(K key, out V value)
        {
            return array.TryGetValue(key, out value);
        }

        public bool ContainsKey(K key)
        {
            V value;
            return array.TryGetValue(key, out value);
        }

        public bool ContainsValue(V value)
        {
            foreach (var foundValue in array.Values)
            {
                if (value.Equals(foundValue))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<K> Keys
        {
            get
            {
                foreach (K key in array.Keys)
                {
                    yield return key;
                }
            }
        }

        public IEnumerable<V> Values
        {
            get
            {
                foreach (var value in array.Values)
                {
                    yield return value;
                }
            }
        }

        public void Clear()
        {
            array.Clear();
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        private void GrowArray()
        {
            HashTableArray<K, V> largerArray = new HashTableArray<K, V>(array.Capacity * 2);

            foreach (var node in array.Items)
            {
                if (node == null)
                {
                    largerArray.Add(default(K), default(V));
                }
                else
                {
                    largerArray.Add(node.Key, node.Value);
                }
            }

            array = largerArray;
            maxItemsAtCurrentSize = (int)(array.Capacity * fillFactor) + 1;
        }
    }
}
