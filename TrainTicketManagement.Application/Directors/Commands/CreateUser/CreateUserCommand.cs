using MediatR;

namespace TrainTicketManagement.Application.Directors.Commands.CreateUser;

public class CreateUserCommand : IRequest<int>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string PeselNumber { get; set; }

    public DateTime DateOfBirth { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }

    public string UserName { get; set; }
    
    public string DomainName { get; set; }
    
}