using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Application.Common.Interfaces;

public interface IUserDbContext
{
     DbSet<Seat> Seats { get; set; }
     DbSet<Ticket> Tickets { get; set; }
     DbSet<Train> Trains { get; set; }
     DbSet<User> Users { get; set; }

     Task<int> SaveChangesAsync(CancellationToken cancellationToken);

     



}