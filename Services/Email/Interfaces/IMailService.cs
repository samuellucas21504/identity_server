using DotNet8Authentication.Models;

namespace DotNet8Authentication.Services.Interfaces;

public interface IMailService
{
    public bool SendMail(MailData mailData);
}