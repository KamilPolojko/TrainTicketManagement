using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.ValueObjects;

namespace TrainTicketManagement.Domain.Entities;

public class Ticket :AuditableEntity
{
    
    // public string TicketName { get; set; }
    
    public int NumberOfSeat { get; set; }
    
    public string NameOfTrainClass { get; set; }
    
    public decimal Price { get; set; }
    
    public string TrainRelief { get; set; }
    

    public DateTime TravelStartTime { get; set; }

    public ICollection<DateTime> ChangeStationsSchedule { get; private set; } = new List<DateTime>();
    
    public DateTime TravelFinishTime { get; set; }
    
    
    
    public ICollection<Train> Trains { get; set; }
    
    public int UserId { get; set; }
    
    public User User { get; set; }
    
}