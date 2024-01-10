using MediatR;

namespace TrainTicketManagement.Application.Directors.Commands.DeleteUser;

public class DeleteUserCommand : IRequest
{
    public int UserId { get; set; }
}