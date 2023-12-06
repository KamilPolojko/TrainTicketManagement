using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/cities-connections")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class RouteBetweenCitiesController : Controller
{

    
    private readonly ILogger<RouteBetweenCitiesController> _logger;

    public RouteBetweenCitiesController(ILogger<RouteBetweenCitiesController> logger)
    {
        _logger = logger;
    }
    
    
    //Tutaj będzie zawarta ilość przesiadek
    
}