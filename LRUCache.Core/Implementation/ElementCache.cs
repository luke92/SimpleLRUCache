using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache.Core.Implementation
{
    public class ElementCache<K, V>
    {
        public K Key { get; }
        public V Value { get; }

        public ElementCache(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public ElementCache(K key)
        {
            Key = key;
            Value = default(V);
        }

        public override bool Equals(object obj)
        {
            return obj is ElementCache<K, V> cache &&
                   EqualityComparer<K>.Default.Equals(Key, cache.Key);
        }

        public override int GetHashCode()
        {
            return 990326508 + EqualityComparer<K>.Default.GetHashCode(Key);
        }


    }
}
