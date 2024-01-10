using MediatR;
using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Application.Common.Interfaces;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Application.Directors.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
{
    private readonly IUserDbContext _context;
    public UpdateUserCommandHandler(IUserDbContext userDbContext)
    {
        _context = userDbContext;
    }


    public async Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        
        var user = await _context.Users.Where(p => p.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);


        user.PersonName = new Domain.ValueObjects.PersonName()
            { FirstName = request.FirstName, LastName = request.LastName };
        user.PeselNumber = request.PeselNumber;
        user.DateOfBirth = request.DateOfBirth;
        user.Email = new Domain.ValueObjects.Email() { UserName = request.UserName, DomainName = request.DomainName };

        _context.Users.Update(user);
        
        await _context.SaveChangesAsync(cancellationToken);

        return user.Id; 
    }
}