using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}