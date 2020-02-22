using System;
using System.Runtime.Caching;

namespace AppPrivy.CrossCutting.Cache
{
    public class TemporaryMemory
    {

        private ObjectCache cache = MemoryCache.Default;
        private CacheItemPolicy cacheItemPolicy;
        private static TemporaryMemory _temporary;

        private TemporaryMemory() { }

        public static TemporaryMemory GetInstance()
        {
            if (_temporary == null)
                _temporary = new TemporaryMemory();
            return _temporary;
        }



        public void CacheSave(string key, object value)
        {
            cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(10.0);
            cache.Add(key, value, cacheItemPolicy);
        }

        public object GetCache(string key)
        {
            if (cache.GetCacheItem(key) != null)
                return cache.Get(key);
            return null;
        }

    }
}
