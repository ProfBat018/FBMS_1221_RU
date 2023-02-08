/*
    c#11
*/

#region RawStringLiteral

//var a = """
//dfgsfg
//        dgghdgfhfdg
//""";

//Console.WriteLine(a);

#endregion

using System.Net;
using System.Net.Mail;

SmtpClient Client = new SmtpClient()
{
    Host = "smtp.gmail.com",
    Port = 587,
    EnableSsl = true,
    DeliveryMethod = SmtpDeliveryMethod.Network,
    UseDefaultCredentials = false,
    Credentials = new NetworkCredential()
    {
        UserName = "elvin.azim01@gmail.com",
        Password = "wuzwxevashmbdfhx" 
    }
};

MailAddress FromeMail = new MailAddress("elvin.azim01@gmail.com", "From");
MailAddress ToeMail = new MailAddress("azimov_e@itstep.org", "To");


MailMessage Message = new MailMessage()
{
    From = FromeMail,
    Subject = "Test",
    Body = "Hello World"
};

Message.To.Add(ToeMail);

try
{
    Client.Send(Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}