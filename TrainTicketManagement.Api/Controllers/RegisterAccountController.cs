using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/register-acounts")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class RegisterAccountController : Controller
{
 
    private readonly ILogger<RegisterAccountController> _logger;

    public RegisterAccountController(ILogger<RegisterAccountController> logger)
    {
        _logger = logger;
    }
    
    
}