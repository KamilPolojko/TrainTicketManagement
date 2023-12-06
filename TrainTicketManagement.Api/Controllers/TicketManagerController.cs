using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/tickets")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class TicketManagerController : Controller
{
    private readonly ILogger<TicketManagerController> _logger;

    public TicketManagerController(ILogger<TicketManagerController> logger)
    {
        _logger = logger;
    }
    
    
    
}