namespace QLCHWF.IServices;

public interface IEmailService
{
    public Task SendMail(string to, string subject, string body);
}