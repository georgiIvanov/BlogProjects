using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HashImplementation
{
    internal class HashTableArray<K, V>
    {
        ArrayNode<K, V>[] array;

        public HashTableArray(int capacity)
        {
            array = new ArrayNode<K, V>[capacity];
        }

        public void Add(K key, V value)
        {
            if (key == null || value == null)
            {
                return;
            }

            int index = GetIndex(key);
            if (array[index] == null)
            {
                array[index] = new ArrayNode<K, V>();
                
            }
            array[index].Add(key, value);
        }

        public void Update(K key, V value)
        {
            int index = GetIndex(key);
            if (array[index] == null)
            {
                throw new ArgumentException("Element does not exist");
            }
            
            array[index].Update(key, value);
            
        }

        public bool Remove(K key)
        {
            return array[GetIndex(key)].Remove(key);
        }

        public bool TryGetValue(K key, out V value)
        {
            int index = GetIndex(key);
            if (array[index] == null)
            {
                value = default(V);
                return false;
            }
            return array[index].TryGetValue(key, out value);
        }

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public void Clear()
        {
            foreach (var node in array)
            {
                node.Clear();
            }
        }

        public IEnumerable<V> Values
        {
            get
            {
                foreach (var node in array)
                {
                    foreach (var value in node.Values)
                    {
                        yield return value;
                    }
                }
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                foreach (var node in array)
                {
                    foreach (var key in node.Keys)
                    {
                        yield return key;
                    }
                    
                }
            }
        }

        public IEnumerable<KeyValuePair<K, V>> Items
        {
            get
            {
                List<KeyValuePair<K, V>> items = new List<KeyValuePair<K, V>>();
                foreach (var node in array)
                {
                    if (node != null)
                    {
                        foreach (var pair in node.Items)
                        {
                            items.Add(pair);
                        }
                    }
                    else
                    {
                        items.Add(null);
                    }
                }

                return items;
            }
        }

        private int GetIndex(K key)
        {
            return Math.Abs(key.GetHashCode() % Capacity);
        }
    }
}
