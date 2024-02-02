namespace WebApplication1.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(string to, string cc, string subject, string body);
    }
}
