using TrainTicketManagement.Domain.Common;

namespace TrainTicketManagement.Domain.Entities;

public class City:AuditableEntity
{
    public string Name { get; set; }
    
    public int TrainId { get; set; }
    public ICollection<Train> Trains { get; set; }


}