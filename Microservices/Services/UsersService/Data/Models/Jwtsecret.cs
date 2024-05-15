using System;
using System.Collections.Generic;

namespace UsersService.Data.Models;


public class Jwtsecret
{
    public int SecretId { get; set; }

    public string Secret { get; set; } = null!;
}
