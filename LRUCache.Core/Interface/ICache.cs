namespace LRUCache.Core.Interface
{
    public interface ICache<K,V> where K : class where V : class
    {
        void Set(K key, V value);

        V Get(K key);
    }
}
