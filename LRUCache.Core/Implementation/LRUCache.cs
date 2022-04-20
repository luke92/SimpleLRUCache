using LRUCache.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LRUCache.Core.Implementation
{
    public class LRUCacheImplementation<K,V> : ICache<K,V> where K : class where V : class
    {
        private int? _maxItems;
        private List<ElementCache<K,V>> _list = new List<ElementCache<K,V>>();

        public LRUCacheImplementation(int? maxItems = null)
        {
            _maxItems = maxItems;
        }

        public ElementCache<K,V> GetElement(int index)
        {
            return _list.ElementAtOrDefault(index);
        }

        public V Get(K key)
        {
            var element = _list.FirstOrDefault(x => x.Key == key);

            if (element != null)
            {
                _list.Remove(element);
                _list.Insert(0, element);
                return element.Value;
            }
            return default(V);
        }

        public void Set(K key, V value)
        {
            var element = _list.FirstOrDefault(x => x.Key == key);

            if (element != null)
            {
                _list.Remove(element);
            }
            if (_maxItems.HasValue && _maxItems.Value == _list.Count)
            {
                _list.RemoveAt(_list.Count - 1);
            }
            _list.Insert(0, new ElementCache<K, V>(key, value));
        }

        public override string ToString()
        {
            return "{" + string.Join(",", _list.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";
        }

    }
}
