using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Domain.Common;


namespace TrainTicketManagement.Persistance;

public class TrainDbContext : DbContext
{
    public TrainDbContext(DbContextOptions<TrainDbContext> options): base(options)
    {
        
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = string.Empty;
                    entry.Entity.Created = DateTime.Now;
                    entry.Entity.StatusID = 1;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = DateTime.Now;
                    break;
                case EntityState.Deleted:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = DateTime.Now;
                    entry.Entity.Inactivated = DateTime.Now;
                    entry.Entity.InactivatedBy = string.Empty;
                    entry.Entity.StatusID = 0;
                    entry.State = EntityState.Modified;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);

    }
}