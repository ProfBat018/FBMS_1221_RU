# Claims 

В WEB разработке 
`Claim` - это объект, который содержит информацию о пользователе, которая может быть использована для проверки доступа к ресурсам.

Пример создания `Claim`:

```csharp
var claims = new List<Claim>
{
    new Claim(ClaimTypes.Name, "John"),
    new Claim(ClaimTypes.Email, "foo@gmail.com"),
    new Claim(ClaimTypes.Role, "Admin"),
};
```

Самая главная ошибка, которая возникает у начинающих. Это то
что вы путаете `Claim` и `Roles`.

`Claim` - это не роль, а просто информация о пользователе.
Эта информация может быть использована для проверки доступа к ресурсам.

Например, если у вас есть ресурс, который доступен только для пользователей с ролью `Admin`.

Или же, если у пользователя нет почты, то он не может подтвердить свой аккаунт.

Роль, в свою очередь, это просто `Claim`, который имеет тип `ClaimTypes.Role`. И по этому типу, вы можете проверить, есть ли у пользователя роль `Admin` или нет. 

```csharp
  private List<Claim> CreateClaims(IdentityUser user)
    {
        try
        {
            var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, "TokenForTheApiWithAuth"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)),
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email)
                };
            return claims;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
```

## JwtRegisteredClaimNames
`Sub` - это уникальный идентификатор пользователя.
`Jti` - это уникальный идентификатор токена. По сути и есть сам токен
`Iat` - это время создания токена