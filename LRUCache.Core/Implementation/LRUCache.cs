using LRUCache.Core.Interface;
using System.Collections.Generic;
using System.Linq;

namespace LRUCache.Core.Implementation
{
    public class LRUCacheImplementation<K,V> : ICache<K,V> where K : class where V : class
    {
        private int? _maxItems;
        private Dictionary<K, V> _cache = new Dictionary<K, V>();

        public LRUCacheImplementation(int? maxItems = null)
        {
            _maxItems = maxItems;
        }

        public V Get(K key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                _cache.Remove(key);
                _cache.Add(key, value);
                return value;
            }
            return default(V);
        }

        public void Set(K key, V value)
        {
            if (_cache.TryGetValue(key, out var valueInCache))
            {
                _cache.Remove(key);
            }
            if (_maxItems.HasValue && _maxItems.Value == _cache.Count)
            {
                _cache.Remove(LastKey());
            }
            _cache.Add(key, value);
        }

        private V LastValue()
        {
            return _cache[LastKey()];
        }

        private V FirstValue()
        {
            return _cache[FirstKey()];
        }

        private K FirstKey()
        {
            return _cache.Keys.Min();
        }

        private K LastKey()
        {
            return _cache.Keys.Max();
        }

        public override string ToString()
        {
            return "{" + string.Join(",", _cache.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";
        }

    }
}
