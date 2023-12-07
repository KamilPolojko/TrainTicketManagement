using Microsoft.EntityFrameworkCore;

namespace TrainTicketManagement.Persistance;

public class UserDbContextFactory: DesignTimeDbContextFactoryBase<UserDbContext>
{
    protected override UserDbContext CreateNewInstance(DbContextOptions<UserDbContext> options)
    {
        return new UserDbContext(options);
    }
}