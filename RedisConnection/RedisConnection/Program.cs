using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;
//...
ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
IDatabase db = redis.GetDatabase();

db.StringSet("foo", "bar");
Console.WriteLine(db.StringGet("foo")); // prints bar



