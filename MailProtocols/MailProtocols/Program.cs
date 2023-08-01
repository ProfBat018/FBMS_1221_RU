// SMTP client with gmail 

/*
// using System.Net;
// using System.Net.Mail;
//
// MailAddress fromAddress = new("profbat018@gmail.com", "Prof. Bat");
//
// Console.WriteLine("Enter receiver address: ");
// var entry = Console.ReadLine();
//
// MailAddress toAddress = new(entry);
// MailMessage mailMessage = new(fromAddress, toAddress);
//
// Console.WriteLine("Enter subject: ");
// mailMessage.Subject = Console.ReadLine();
//
// Console.WriteLine("Enter body: ");
// mailMessage.IsBodyHtml = true;
// mailMessage.Body = $"""<html><body><h1>{Console.ReadLine()}</h1><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0cyduXNkqqHrdNMkJ2EqmncQbXgDri5sH6A&usqp=CAU"></img></body></html>""";
//
// // mailMessage.Attachments.Add(new Attachment(,));
//
// SmtpClient smtpClient = new("smtp.gmail.com", 587);
//
// smtpClient.Credentials = new NetworkCredential("profbat018@gmail.com", "nlliksumtxmfoynd");
// smtpClient.EnableSsl = true;
//
// smtpClient.Send(mailMessage);
//
// Console.WriteLine("Mail sent successfully");
//
*/

// IMAP client with gmail

using MailKit;
using MailKit.Net.Imap;

void FetchEmails()
{
    string host = "imap.gmail.com";
    int port = 993;
    bool useSsl = true;
    string username = "profbat018@gmail.com";
    string password = "nlliksumtxmfoynd";

    using (var client = new ImapClient())
    {
        client.Connect(host, port, useSsl);

        client.Authenticate(username, password);

        client.Inbox.Open(FolderAccess.ReadOnly);

        int count = client.Inbox.Count;
        int startIndex = count > 10 ? count - 10 : 0;
        for (int i = startIndex; i < count; i++)
        {
            var message = client.Inbox.GetMessage(i);

            Console.WriteLine("Subject: " + message.Subject);
            Console.WriteLine("From: " + message.From);
            Console.WriteLine("Body: " + message.TextBody);
            Console.WriteLine("-----------------------------------");
        }

        client.Disconnect(true);
    }
}

FetchEmails();