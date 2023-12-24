using TrainTicketManagement.Domain.Common;

namespace TrainTicketManagement.Domain.Entities;

public class Seat:AuditableEntity
{
    
    public int NumberOfSeat { get; set; }

    public bool IsOccupied { get; set; }
    
    
    public int TrainId { get; set; }

    public Train Train { get; set; }
    
}