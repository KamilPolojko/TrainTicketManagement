using MediatR;
using TrainTicketManagement.Application.Common.Interfaces;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Application.Directors.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserDbContext _context;
    
    public CreateUserCommandHandler(IUserDbContext userDbContext)
    {
        _context = userDbContext;
    }
    
    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = new()
        {
            PersonName = new Domain.ValueObjects.PersonName()
                { FirstName = request.FirstName, LastName = request.LastName },
            Login = request.Login,
            Password = request.Password,
            PeselNumber = request.PeselNumber,
            DateOfBirth = request.DateOfBirth,
            Email = new Domain.ValueObjects.Email(){ UserName = request.UserName, DomainName = request.DomainName}
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync(cancellationToken);

        return user.Id;

    }
}