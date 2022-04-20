using LRUCache.Core.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LRUCache.Tests
{
    [TestClass]
    public class LRUCacheTests
    {
        [TestMethod]
        public void CheckOrderOK()
        {
            var cache = new LRUCacheImplementation<string, string>(3);
            cache.Set("key3", "3");
            cache.Set("key2", "2");
            cache.Set("key4", "4");

            Assert.AreEqual(cache.GetElement(0).Key, "key4");
            Assert.AreEqual(cache.GetElement(1).Key, "key2");
            Assert.AreEqual(cache.GetElement(2).Key, "key3");

            cache.Get("key2");

            Assert.AreEqual(cache.GetElement(0).Key, "key2");

            cache.Set("key1", "1");

            Assert.AreEqual(cache.GetElement(0).Key, "key1");
            Assert.AreEqual(cache.GetElement(2).Key, "key4");

            cache.Set("key4", "newValue4");
            Assert.AreEqual(cache.GetElement(0).Key, "key4");

        }

        [TestMethod]
        public void CheckElementNotExists()
        {
            var cache = new LRUCacheImplementation<string, string>(3);
            cache.Set("key3", "3");
            cache.Set("key2", "2");
            cache.Set("key4", "4");

            var valueOfKeyNonExists = cache.Get("key1");

            Assert.AreEqual(valueOfKeyNonExists, null);
        }
    }
}
