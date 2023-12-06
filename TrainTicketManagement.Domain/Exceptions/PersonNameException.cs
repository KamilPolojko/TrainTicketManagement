namespace TrainTicketManagement.Domain.Exceptions;

public class PersonNameException:Exception
{
    public PersonNameException(string personName, Exception ex): base($"Person Name \"{personName}\"is invalid",ex)
    {
        
    }
}