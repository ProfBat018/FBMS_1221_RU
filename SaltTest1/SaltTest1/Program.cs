////using static BCrypt.Net.BCrypt;



////string password = HashPassword("Elvin_123");

////Console.WriteLine(password);

////Console.Write("Enter your password: ");
////var entry = Console.ReadLine();

////bool isVerified = Verify(entry, password);

////Console.WriteLine(isVerified);

////// $2b$10$dhNR9zo64v.BsqMP0GySFufF/Og.Cjzs8VPArBaVQF9AqhfnCYapC


//using Microsoft.IdentityModel.Tokens;
//using System.Text;

//var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Elvin_123"));

//Console.WriteLine(key.KeyId);
//Console.WriteLine(Encoding.UTF8.GetString(key.Key));


Console.WriteLine(Guid.NewGuid().ToString());
