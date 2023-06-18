using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit.Encodings;
using MimeKit;
using SendEmailsWebAPI.SendEmails;
using System.Net.Mail;

namespace SendEmailsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly NotificationMetadata _notificationMetadata;
        public HomeController(IOptions<NotificationMetadata> options)
        {
            _notificationMetadata = options.Value;
        }
        public string Get()
        {
            EmailMessage message = new EmailMessage();
            message.Sender = new MailboxAddress("Self", _notificationMetadata.Sender);
            message.Reciever = new MailboxAddress("Self", _notificationMetadata.Reciever);
            message.Subject = "Welcome";
            message.Content = "Hello World!";
            var mimeMessage = CreateMimeMessageFromEmailMessage(message);
            using (SmtpClient smtpClient = new SmtpClient())
            {
                //smtpClient.Connect(_notificationMetadata.SmtpServer,_notificationMetadata.Port, true);
                //smtpClient.Authenticate(_notificationMetadata.UserName,_notificationMetadata.Password);
                //smtpClient.Send(mimeMessage);
                //smtpClient.Disconnect(true);
            }
            return "Email sent successfully";
        }
        private MimeMessage CreateMimeMessageFromEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            { Text = message.Content };
            return mimeMessage;
        }
    }
}
