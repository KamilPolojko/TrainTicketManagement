namespace TrainTicketManagement.Domain.Exceptions;

public class TrainNameException:Exception
{
    public TrainNameException(string trainName, Exception ex): base($"Train Name \"{trainName}\"is invalid",ex)
    {
        
    }
}