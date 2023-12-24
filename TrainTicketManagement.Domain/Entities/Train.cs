using TrainTicketManagement.Domain.Common;
using TrainTicketManagement.Domain.ValueObjects;

namespace TrainTicketManagement.Domain.Entities;

public class Train:AuditableEntity
{

    //Starszy sposób
    // public Train()
    // {
    //     AllSeats = new List<Seat>();
    //     TravelStartTime = new List<DateTime>();
    //     TravelFinishTime = new List<DateTime>();
    // }
   
    public TrainName Name { get; set; }

    public int  QuantityOfCarriage{ get; set; }
    
    public int NumberOfSeatsFirstClass { get; set; }
    
    public int NumberOfSeatsSecondClass { get; set; }
    
    public string BaseStation { get; set; }

    public ICollection<string> ChangeStations { get; private set; } = new List<string>();
    
    public string Destination { get; set; }

    public ICollection<DateTime> TravelStartTime { get; private set; } = new List<DateTime>();

    public ICollection<DateTime> ChangesStationsSchedule { get; private set; } = new List<DateTime>();

    public ICollection<DateTime> TravelFinishTime { get; private set; } = new List<DateTime>();
    
    
    
    public ICollection<Seat> Seats { get; set; }
    
    public int TicketId { get; set; }
    
    public Ticket Ticket { get; set; }
    
}
