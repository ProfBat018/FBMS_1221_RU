
using System.Net;

namespace PetStoreApi.Services.Middlewares;

public class TokenManagerMiddleware : IMiddleware
{
    private readonly ITokenManagerService _tokenManager;

    public TokenManagerMiddleware(ITokenManagerService tokenManager)
    {
        _tokenManager = tokenManager;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (await _tokenManager.IsCurrentActiveTokenAsync())
        {
            await next(context);

            return;
        }
        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
    }
}
