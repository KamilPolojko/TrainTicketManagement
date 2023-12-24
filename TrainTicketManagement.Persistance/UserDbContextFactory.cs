using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Persistance;

public class UserDbContextFactory: DesignTimeDbContextFactoryBase<UserDbContext>
{
    private IDateTime dateTime;
    protected override UserDbContext CreateNewInstance(DbContextOptions<UserDbContext> options)
    {
        return new UserDbContext(options,dateTime);
    }
}