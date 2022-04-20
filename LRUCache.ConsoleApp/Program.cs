using LRUCache.Core.Implementation;
using System;

namespace LRUCache.ConsoleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var cache = new LRUCacheImplementation<string,string>(3);

            cache.Set("key3", "3");
            cache.Set("key2", "2");
            cache.Set("key4", "4");
            Console.WriteLine(cache);

            cache.Get("key2");
            Console.WriteLine(cache);

            cache.Set("key1", "1");
            Console.WriteLine(cache);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
