using System;
using System.Collections.Generic;
using RedisExample.Models;

namespace RedisExample;

public partial class Manager : ICacheEntity
{
    public string? Manager1 { get; set; }

    public string Employee { get; set; } = null!;
}
