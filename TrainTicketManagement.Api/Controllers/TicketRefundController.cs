using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/refund-tickets")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class TicketRefundController : Controller
{
    private readonly ILogger<TicketRefundController> _logger;

    public TicketRefundController(ILogger<TicketRefundController> logger)
    {
        _logger = logger;
    }
  
}