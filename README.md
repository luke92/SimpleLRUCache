# SimpleLRUCache
Simple LRU Cache with C#

An LRUCache (Least Recently Used Cache) is a fixed item size object cache.
To add or update an object in the cache you can use the `set` method:

`LRUCache.set(‘key1’, someComplexObject);`

To retrieve an object in the cache you can use the `get` method:

`LRUCache.get(‘key1’); // Returns someComplexObject`

As the cache grows it will cap at some fixed size described by the `maxItems` property.

When you attempt to add a new object into a full cache, it will discard the Least Recently Used cached item
Calling the `set` or `get` methods constitutes a “use” of ‘key’.