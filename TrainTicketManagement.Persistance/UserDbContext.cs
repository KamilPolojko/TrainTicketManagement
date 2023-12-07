using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Persistance;

using Microsoft.EntityFrameworkCore;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Train> Trains { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Train>().OwnsOne(p => p.Name);
        modelBuilder.Entity<User>().OwnsOne(p => p.PersonName);
        modelBuilder.Entity<User>().OwnsOne(p => p.Email);
        
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