using StackExchange.Redis.Extensions.Core;
using System.Collections.Generic;
using System.Linq;

namespace RedisStorage
{
    public class CacheAdapter
    {
        ICacheClient myCacheClient;
        private readonly string KeyPrefix = "pdcache.";
        public CacheAdapter()
        {
            myCacheClient = CacheConnector.RedisClient;
        }
        public T Get<T>(string key)
        {
            var data = myCacheClient.Get<T>(key);
            return data;
        }

        public void Add<T>(string key, T value)
        {
            myCacheClient.Add(key, value);

        }

        public IList<T> GetAll<T>()
        {
            var keys = myCacheClient.SearchKeys(KeyPrefix + "*").Select(a => a.Replace(KeyPrefix, ""));
            var res = myCacheClient.GetAll<T>(keys);
            var list = res.Select(a => a.Value).ToList();
            return list;
        }

        public void Update<T>(string key, T value)
        {
            myCacheClient.Remove(key);
            Add(key, value);
        }
    }
}
