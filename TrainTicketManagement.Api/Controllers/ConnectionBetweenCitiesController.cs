using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/cities-connections")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class ConnectionBetweenCitiesController : Controller
{

    
    private readonly ILogger<ConnectionBetweenCitiesController> _logger;

    public ConnectionBetweenCitiesController(ILogger<ConnectionBetweenCitiesController> logger)
    {
        _logger = logger;
    }
    
    //Tutaj będzie zawarta ilość przesiadek
    
}