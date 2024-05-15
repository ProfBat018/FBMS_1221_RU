using System;
using System.Collections.Generic;

namespace UsersService.Data.Models;

public class BlacklistedToken
{
    public int TokenId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime? BlacklistedAt { get; set; }
}
