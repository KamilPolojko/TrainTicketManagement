using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TrainTicketManagement.Application.Directors.Commands.CreateUser;
using TrainTicketManagement.Application.Directors.Queries.GetUserDetail;

namespace TrainTicketManagement.Api.Controllers;

[Route("api/users")]
[ApiController]
[EnableCors("MyAllowSpecificOrigins")]
public class UserManagerController : BaseController
{

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDetailVm>> GetDetails(int id)
    {
        var vm = await Mediator.Send(new GetUserDetailQuery() { UserId = id });

        return vm;
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser(CreateUserCommand command)
    {
        var result = await Mediator.Send(command);
        return Ok(result);
    }
    
}