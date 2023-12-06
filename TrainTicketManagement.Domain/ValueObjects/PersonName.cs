using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Exceptions;

namespace TrainTicketManagement.Domain.ValueObjects;

public class PersonName:ValueObject
{
    
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }


    public override string ToString()
    {
        var personName= $"{FirstName} {LastName}";

        try
        {
            return personName;

        }
        catch (Exception e)
        {
            throw new PersonNameException(personName, e);

        }
    }
    
    

    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return LastName;
    }
}