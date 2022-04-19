using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache.Core.Interface
{
    public interface ICache<K,V> where K : class where V : class
    {
        void Set(K key, V value);

        V Get(K key);
    }
}
