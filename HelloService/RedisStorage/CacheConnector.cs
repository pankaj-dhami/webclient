using Newtonsoft.Json;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Newtonsoft;
using System;

namespace RedisStorage
{
    public class CacheConnector
    {
        static CacheConnector() 
        {
            var jsonSetting = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            var serializer = new NewtonsoftSerializer(jsonSetting);
            var redisConnectionString = "pdcache.redis.cache.windows.net:6380,password=IMOaJsK7Y4YrBZ3xygHT7tBLrYX6aZY4i2LNKa9Qof8=,ssl=True,abortConnect=False";
            var keyPrefix = "pdcache.";

            RedisClient = new StackExchangeRedisCacheClient(serializer, redisConnectionString, keyPrefix);
        }

        public static  ICacheClient RedisClient;

     

    }
}
