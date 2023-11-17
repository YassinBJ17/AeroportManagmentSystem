namespace AMS.ApplicationCore.Domain
{
    public class FlightBase
    {
        public string Departure { get; set; } = String.Empty;
        public string Destination { get; set; } = String.Empty;
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public virtual IList<Passenger>? Passenger { get; set; }
        // Prop de navigation
        public virtual Plane? Plane { get; set; }
    }
}