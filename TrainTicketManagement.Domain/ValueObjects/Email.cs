﻿using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.Exceptions;

namespace TrainTicketManagement.Domain.ValueObjects;

public class Email : ValueObject
{
    
    public string UserName { get; set; }
    
    public string DomainName { get; set; }

    public static Email For(string email)
    {
        var emailObj = new Email();
        try
        {
            var index = email.IndexOf("@", StringComparison.Ordinal);
            emailObj.UserName = email.Substring(0, index);
            emailObj.DomainName = email.Substring(index + 1);
        }
        catch (Exception ex)
        {
            throw new EmailException(email, ex);
        }

        return emailObj;
    }
    
    public override string ToString()
    {
        return   $"{UserName}@{DomainName}";
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}