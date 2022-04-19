using LRUCache.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache.Core.Implementation
{
    public class LRUCache<K,V> : ICache<K,V> where K : class where V : class
    {
        public V Get(K key)
        {
            throw new NotImplementedException();
        }

        public void Set(K key, V value)
        {
            throw new NotImplementedException();
        }
    }
}
