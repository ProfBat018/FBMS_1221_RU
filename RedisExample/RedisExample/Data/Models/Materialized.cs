using System;
using System.Collections.Generic;
using RedisExample.Models;

namespace RedisExample;

public partial class Materialized : ICacheEntity
{
    public string Manager { get; set; } = null!;
}
