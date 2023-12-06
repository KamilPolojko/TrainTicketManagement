using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/acounts")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class UserManagerController : Controller
{

    private readonly ILogger<UserManagerController> _logger;

    public UserManagerController(ILogger<UserManagerController> logger)
    {
        _logger = logger;
    }
    
    
}