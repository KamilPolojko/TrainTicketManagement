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
    
    public City BaseStation { get; set; }

    public ICollection<City> ChangeStations { get; private set; } = new List<City>();
    
    public City Destination { get; set; }

    public ICollection<DateTime> TravelStartTime { get; private set; } = new List<DateTime>();

    public ICollection<DateTime> ChangesStationsSchedule { get; private set; } = new List<DateTime>();

    public ICollection<DateTime> TravelFinishTime { get; private set; } = new List<DateTime>();
    

    
    public ICollection<Seat> Seats { get; set; }
    
    
    public int TicketId { get; set; }
    
    public Ticket Ticket { get; set; }
    
    public int CityId { get; set; }
    public ICollection<City> Cities { get; set; }
}
