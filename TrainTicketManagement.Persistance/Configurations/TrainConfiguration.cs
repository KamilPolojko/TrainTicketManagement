using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Persistance.Configurations;

public class TrainConfiguration : IEntityTypeConfiguration<Train>
{
    public void Configure(EntityTypeBuilder<Train> builder)
    {
        builder.OwnsOne(p => p.Name).Property(p=>p.FirstPartOfName).HasColumnName("FirstPartOfTheName").IsRequired();
        builder.OwnsOne(p => p.Name).Property(p=>p.SerialNumberOfTrain).HasColumnName("SerialNumberOfTrain").IsRequired();
        
        
    }
}