namespace TrainTicketManagement.Persistance;

using Microsoft.EntityFrameworkCore;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }
    
    
    
    
}