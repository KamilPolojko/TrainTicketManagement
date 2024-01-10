using MediatR;

namespace TrainTicketManagement.Application.Directors.Commands.UpdateUser;

public class UpdateUserCommand : IRequest<int>
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PeselNumber { get; set; }

    public DateTime DateOfBirth { get; set; }
    
    public string UserName { get; set; }
    
    public string DomainName { get; set; }
    
}