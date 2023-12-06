using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.ValueObjects;

namespace TrainTicketManagement.Domain.Entities;

public class User:AuditableEntity
{
    public PersonName PersonName { get; set; }
    
    public string PeselNumber { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public Email Email { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }
    
    
    
    public ICollection<Ticket> Tickets { get; set; }
    
}