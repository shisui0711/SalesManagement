namespace QLCHWF.Models;

public class EmailSetting
{
    //"SmtpServer": "",
    //"Port": 443,
    //"Email": "",
    //"Password": "",
    //"SenderName": ""
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string SenderName { get; set; }
    public bool EnableSsl { get; set; }
}