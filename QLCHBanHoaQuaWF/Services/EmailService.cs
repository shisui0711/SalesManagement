using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using QLCHWF.IServices;
using QLCHWF.Models;

namespace QLCHWF.Services
{
    public class EmailService:IEmailService
    {
        public bool SendMail(EmailSetting setting, MailMessage mailMessage)
        {
            SmtpClient smtpClient = new SmtpClient(setting.SmtpServer, setting.Port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(setting.Email, setting.Password);
            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> SendMailAsync(EmailSetting setting, MailMessage mailMessage)
        {

            SmtpClient smtpClient = new SmtpClient(setting.SmtpServer, setting.Port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(setting.Email, setting.Password);
            try
            {
               await smtpClient.SendMailAsync(mailMessage);
               return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
