namespace XUnitTestExample.Models
{
    public interface IEmailService
    {
        bool isEmailAvailable();
        void SendEmail();
    }
    public class EmailService : IEmailService
    {
        public bool isEmailAvailable()
        {
            return true;
        }

        public void SendEmail()
        {
            Console.WriteLine("Email Send");
        }
    }

}
