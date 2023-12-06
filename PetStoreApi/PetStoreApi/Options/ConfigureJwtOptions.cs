//using System.Text;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authentication.OAuth;
//using Microsoft.Extensions.Options;
//using Microsoft.IdentityModel.Tokens;

//namespace PetStoreApi.Options;
//public class ConfigureJwtOptions : IConfigureOptions<JwtBearerOptions>
//{
//    private readonly IConfiguration _configuration;


//    public ConfigureJwtOptions(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }


//    public void Configure(JwtBearerOptions options)
//    {
//        _configuration.GetSection("Jwt").Bind(options);
//    }
//}
