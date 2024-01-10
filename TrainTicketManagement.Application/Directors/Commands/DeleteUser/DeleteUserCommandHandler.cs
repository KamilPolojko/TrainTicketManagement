using MediatR;
using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Application.Directors.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
{
    private readonly IUserDbContext _context;

    public DeleteUserCommandHandler(IUserDbContext userDbContext)
    {
        _context = userDbContext;
    }
    
    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.Where(p => p.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);

        _context.Users.Remove(user);

        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}