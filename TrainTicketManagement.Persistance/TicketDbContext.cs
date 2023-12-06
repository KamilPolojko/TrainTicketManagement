using Microsoft.EntityFrameworkCore;

namespace TrainTicketManagement.Persistance;

public class TicketDbContext : DbContext
{
    public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
    {
        
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     Sztywne wpisywanie relacji za pomocą nadpisania funkcji budującej 
    // }
    
    
    
}