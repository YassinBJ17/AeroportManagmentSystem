using AMS.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces;

public interface IServiceFlight
{
    public IList<DateTime> GetFlightDates(string destination);
    public void GetFlights(string filterType, string filterValue);
    public void ShowFlightDetails(Plane plane);
    public int ProgrammedFlightNumber(DateTime startDate);
    public double DurationAverage(string destination);
    public IEnumerable<Flight> OrderedDurationFlights();
    public IList<Passenger> SeniorTravellers(Flight flight);
    public IList<Traveller> SeniorTravellers2(Flight flight);
    public IList<string> SeniorTravellersNationalities(Flight flight);
    public void ShowDestinationGroupedFlights();
    public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
}
