using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Persistance.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        
        builder.HasKey(p => p.Id);
        

        builder.Property(p => p.PeselNumber).HasMaxLength(11).IsRequired();

        builder.OwnsOne(p => p.PersonName).Property(p=>p.FirstName).HasColumnName("FirstName").IsRequired();
        builder.OwnsOne(p => p.PersonName).Property(p=>p.LastName).HasColumnName("LastName").IsRequired();
        
        builder.OwnsOne(p => p.Email).Property(p => p.UserName).HasColumnName("MailName").IsRequired();
        builder.OwnsOne(p => p.Email).Property(p => p.DomainName).HasColumnName("MailDomain").IsRequired();
        
    }
}