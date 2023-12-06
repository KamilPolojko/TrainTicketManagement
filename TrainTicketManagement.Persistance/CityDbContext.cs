using Microsoft.EntityFrameworkCore;

namespace TrainTicketManagement.Persistance;

public class CityDbContext :DbContext
{
    public CityDbContext(DbContextOptions<CityDbContext> options): base(options)
    {
        
    }
    
    
    
    
    
}
