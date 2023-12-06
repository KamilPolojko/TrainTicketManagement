using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.ValueObjects;

namespace TrainTicketManagement.Domain.Entities;

public class Ticket :AuditableEntity
{
    
    // public string TicketName { get; set; }
    
    public int NumberOfSeat { get; set; }
    
    public string NameOfTrainClass { get; set; }
    
    public float Price { get; set; }
    
    public string TrainRelief { get; set; }
    
    public City BaseStation { get; set; }
    
    public ICollection<City> ChangeStations { get; private set; } = new List<City>();
    
    public City Destination { get; set; }

    public ICollection<DateTime> TravelStartTime { get; private set; } = new List<DateTime>();

    public ICollection<DateTime> ChangeStationsSchedule { get; private set; } = new List<DateTime>();
    
    public ICollection<DateTime> TravelFinishTime { get; private set; } = new List<DateTime>();
    
    
    
    public ICollection<Train> Trains { get; set; }
    
    public int UserId { get; set; }
    
    public User User { get; set; }
    
}