using MimeKit;

namespace SendEmailsWebAPI.SendEmails
{
    public class EmailMessage
    {
        public MailboxAddress Sender { get; set; }
        public MailboxAddress Reciever { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
/*
1. Create an ASP.NET Core WebAPI project
2. Install the NETCore.MailKit NuGet package
3. Add namespaces program.cs 
	using MailKit.Net.Smtp; using MimeKit;
4. Specify email configuration metadata in ASP.NET Core in appSetting.json file.
5. To read appSetting email configuration data, NotificationMetadata class.
6. Read the email configuration data from the appsettings.json file into an instance of NotificationMetadata class in program.cs file
7. Create an instance of the EmailMessage class
8. Create an instance of the MimeMessage class
9. Send emails synchronously using MailKit in ASP.NET Core 
*/