using FluentEmail.Core;
using WebApplication1.Interfaces;

namespace WebApplication1.CrossCutting
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmail(string to, string cc, string subject, string body)
        {
            string from = Convert.ToString(_config["mail_from"]) ?? throw new InvalidOperationException();
            await Email
                .From(from)
                .To(to)
                .Subject(subject)
                .Body(body)
                .SendAsync();
        }
    }
}
