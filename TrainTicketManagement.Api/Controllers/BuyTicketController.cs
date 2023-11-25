using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;



[Route("api/tickets")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class BuyTicketController : Controller
{
    private readonly ILogger<BuyTicketController> _logger;

    public BuyTicketController(ILogger<BuyTicketController> logger)
    {
        _logger = logger;
    }
    
}