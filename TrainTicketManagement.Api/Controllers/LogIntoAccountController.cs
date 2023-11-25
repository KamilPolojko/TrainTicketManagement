using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/acounts")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class LogIntoAccountController : Controller
{

    private readonly ILogger<LogIntoAccountController> _logger;

    public LogIntoAccountController(ILogger<LogIntoAccountController> logger)
    {
        _logger = logger;
    }
    
}