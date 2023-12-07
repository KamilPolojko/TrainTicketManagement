using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Exceptions;

namespace TrainTicketManagement.Domain.ValueObjects;

public class PersonName:ValueObject
{
    
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }


    public override string ToString()
    {
        return   $"{FirstName} {LastName}";
    }
    
    

    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return LastName;
    }
}