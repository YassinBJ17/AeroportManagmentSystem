
namespace AMS.ApplicationCore.Domain;


public class Flight
{
    public string Destination { get; set; } = String.Empty;
    public string Departure { get; set; } = String.Empty;
    public DateTime FlightDate { get; set; }
    public int FlightId { get; set; }
    public DateTime EffectiveArrival { get; set; }
    public int EstimatedDuration { get; set; }
    // Prop de navigation
    public virtual Plane? Plane { get; set; }
    public virtual IList<Passenger>?  Passenger { get; set; }

    public override string ToString()
    {
        return " Flight = Destination = " + Destination +
            " , Departure = " + Departure +
            " , FlightDate = " + FlightDate +
            " , FlightId = " + FlightId +
            " , EffectiveArrival = " + EffectiveArrival +
            " , EstimatedDuration = " + EstimatedDuration;
    }
}
