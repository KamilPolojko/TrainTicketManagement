using MediatR;

namespace TrainTicketManagement.Application.Directors.Queries.GetUserDetail;

public class GetUserDetailQuery : IRequest<UserDetailVm>
{
    public int UserId { get; set; }
    
}