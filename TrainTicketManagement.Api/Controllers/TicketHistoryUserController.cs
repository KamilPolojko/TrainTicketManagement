using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/history-tickets")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class TicketHistoryUserController : Controller
{
    
    private readonly ILogger<TicketHistoryUserController> _logger;

    public TicketHistoryUserController(ILogger<TicketHistoryUserController> logger)
    {
        _logger = logger;
    }
    
}