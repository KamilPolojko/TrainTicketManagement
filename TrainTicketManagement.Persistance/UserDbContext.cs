using System.Reflection;
using TrainTicketManagement.Application.Common.Interfaces;
using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Persistance;

using Microsoft.EntityFrameworkCore;

public class UserDbContext : DbContext, IUserDbContext
{
    private readonly IDateTime _dateTime;
    public UserDbContext(DbContextOptions<UserDbContext> options, IDateTime dateTime) : base(options)
    {
        _dateTime = dateTime;
    }
    
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Train> Trains { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.SeedData();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = string.Empty;
                    entry.Entity.Created = _dateTime.Now;
                    entry.Entity.StatusID = 1;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    break;
                case EntityState.Deleted:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    entry.Entity.Inactivated = _dateTime.Now;
                    entry.Entity.InactivatedBy = string.Empty;
                    entry.Entity.StatusID = 0;
                    entry.State = EntityState.Modified;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);

    }
    
    
}