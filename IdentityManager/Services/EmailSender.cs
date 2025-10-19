using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace IdentityManager.Services
{
    public class EmailSender : IEmailSender 
    {
        public string SendGridKey { get; set; }
        public EmailSender(IConfiguration _config)
        {
            SendGridKey = _config.GetValue<string>("SendGrid:SecretKey");

        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //because not have account send grid  
            /*
            var client = new SendGridClient(SendGridKey);
            var from_email = new EmailAddress("hello@dotnetmastery.com", "DotNetMastery - Identity Manager");

            var to_email = new EmailAddress(email);

            var msg = MailHelper.CreateSingleEmail(from_email, to_email, subject, "", htmlMessage);
            return client.SendEmailAsync(msg);
            */
            Console.WriteLine("================================");
            Console.WriteLine($"To: {email}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Message : Click here to reset : {htmlMessage}");
            Console.WriteLine("================================");
            return Task.CompletedTask;


        }
    }
}
