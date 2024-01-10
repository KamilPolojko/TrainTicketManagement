using Microsoft.EntityFrameworkCore;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Persistance;

public static class Seed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(d =>
            {
                d.HasData(new User()
                {
                    Id = 1,
                    StatusID = 1,
                    Created = DateTime.Now,
                    PeselNumber = "23234576345",
                    DateOfBirth = new DateTime(2003,02,01),
                    Login = "Admin",
                    Password = "Password"
                    
                    
                });
                d.OwnsOne(d => d.PersonName).HasData(new { UserId = 1,FirstName = "Jan", LastName = "Zawadzki" });
                d.OwnsOne(d => d.Email).HasData(new {UserId =1, UserName = "janzawadzki", DomainName = "gmail.com" });
            }
        );
        
        modelBuilder.Entity<Ticket>().HasData(
            new Ticket() { Id=1,UserId=1,NumberOfSeat=100,NameOfTrainClass="First",Price=19.99m,TrainRelief="Student", TravelStartTime = new DateTime(2009,01,01), ChangeStationsSchedule = { new DateTime(2009,01,01) }, TravelFinishTime = new DateTime(2009,01,01)},
            new Ticket() { Id=2,UserId=1,NumberOfSeat=120,NameOfTrainClass="First",Price=16.99m,TrainRelief="Student", TravelStartTime = new DateTime(2007,02,03), ChangeStationsSchedule = { new DateTime(2007,02,03) }, TravelFinishTime = new DateTime(2007,02,03)}
        );
        
        
    
    
        modelBuilder.Entity<Train>(d =>
            {
                d.HasData(new Train()
                {
                    Id = 1,
                    TicketId = 1,
                    StatusID = 1,
                    Created = DateTime.Now,
                    QuantityOfCarriage = 4,
                    NumberOfSeatsFirstClass = 150,
                    NumberOfSeatsSecondClass = 100,
                    BaseStation = "Warszawa",
                    ChangeStations = { "Włocławek", "Kraków", "Choroszcz" },
                    Destination = "Wroclaw",
                    TravelStartTime = { new DateTime(2006,01,03) },
                    ChangesStationsSchedule = { new DateTime(2007,02,14) },
                    TravelFinishTime = { new DateTime(2008,03,24) }
                    
                });
                d.OwnsOne(d => d.Name).HasData(new {TrainId=1, TicketId =1,  FirstPartOfName = "IC", SerialNumberOfTrain = "1620" });
            }
        );
        

        
        modelBuilder.Entity<Seat>().HasData(
            new Seat() {Id=1,TrainId=1,NumberOfSeat=1,IsOccupied=true},
            new Seat() {Id=2,TrainId=1,NumberOfSeat=2,IsOccupied=false}
        );

    }
}