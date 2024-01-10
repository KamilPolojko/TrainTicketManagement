using AutoMapper;
using MediatR;
using TrainTicketManagement.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace TrainTicketManagement.Application.Directors.Queries.GetUserDetail;

public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery,UserDetailVm>
{
    private readonly IUserDbContext _context;
    private readonly IMapper _mapper;
    
    public GetUserDetailQueryHandler(IUserDbContext userDbContext, IMapper mapper)
    {
        _context = userDbContext;
        _mapper = mapper;
    }
    
    public async Task<UserDetailVm> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.Where(p => p.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);

        var userVm = _mapper.Map<UserDetailVm>(user);

        return userVm;
    }
    
    
}