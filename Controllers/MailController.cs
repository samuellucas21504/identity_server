using DotNet8Authentication.Models;
using DotNet8Authentication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8Authentication.Controllers;

[Route("[controller]")]
[ApiController]
public class MailController : ControllerBase
{
    private readonly IMailService _mailService;
    public MailController(IMailService mailService)
    {
        _mailService = mailService;
    }

    [HttpPost]
    [Route("SendMail")]
    public bool SendMail(MailData mailData)
    {
        return _mailService.SendMail(mailData);
    }
}