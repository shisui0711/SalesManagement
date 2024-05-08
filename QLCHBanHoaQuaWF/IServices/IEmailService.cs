using QLCHWF.Models;
using System.Net.Mail;

namespace QLCHWF.IServices;

public interface IEmailService
{
    public bool SendMail(EmailSetting setting, MailMessage mailMessage);
    public Task<bool> SendMailAsync(EmailSetting setting, MailMessage mailMessage);
}