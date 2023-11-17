

using AMS.ApplicationCore.Domain;

namespace AMS.ApplicationCore.Interfaces;

public interface IServiceFlight
{
    public List<Flight> Flights { get; set; } = new List<Flight>();
}
