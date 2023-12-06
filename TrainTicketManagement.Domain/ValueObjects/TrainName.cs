using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Exceptions;

namespace TrainTicketManagement.Domain.ValueObjects;

public class TrainName : ValueObject
{
    public string FirstPartOfName { get; set; }
    
    public string SerialNumberOfTrain { get; set; }


    public override string ToString()
    {
        var trainName = "";
        try
        {
             trainName= $"{FirstPartOfName} {SerialNumberOfTrain}";
            return trainName;

        }
        catch (Exception e)
        {
            throw new TrainNameException(trainName, e);

        }
    }
    
    

    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstPartOfName;
        yield return SerialNumberOfTrain;
    }
}