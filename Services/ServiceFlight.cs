using AM.ApplicationCore.Interfaces;
using AMS.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services;

public class ServiceFlight : IServiceFlight
{
    public List<Flight> Flights { get; set; } = new List<Flight>();
    public void GetFlights(string filterType, string filterValue)
    {
        switch (filterType)
        {
            case "Destination":
                foreach (var f in Flights)
                {
                    if (f.Destination.Equals(filterValue))
                        Console.WriteLine(f.ToString());
                }
                break;
            case "FlightDate":
                foreach (var f in Flights)
                {
                    if (f.FlightDate == DateTime.Parse(filterValue))
                        Console.WriteLine(f.ToString());
                }
                break;
            case "EffectiveArrival":
                foreach (var f in Flights)
                {
                    if (f.EffectiveArrival == DateTime.Parse(filterValue))
                        Console.WriteLine(f.ToString());
                }
                break;
        }
    }
    public IList<DateTime> GetFlightDates(string destination)
    {
        #region boucles
        //IList <DateTime> dates = new List<DateTime>();
        /*for (int i = 0; i < Flights.Count(); i++)
        {
            if (Flights[i].Destination == destination)
                dates.Add(Flights[i].FlightDate);
        }*/
        /*foreach (Flight f in Flights)
        {
            if (f.Destination.Equals(destination))
                dates.Add(f.FlightDate);
        }
        return dates;*/
        #endregion

        
        var query = from f in Flights
                    where f.Destination == destination
                    select f.FlightDate;
        //return query.ToList();

        return Flights.Where(f=>f.Destination==destination).Select(f=>f.FlightDate).ToList();



    }
    public void ShowFlightDetails(Plane plane)
    {
        /*var query = from f in Flights
                    where f.Plane.Equals(plane)
                    //select f;
                    select new { f.Destination, f.FlightDate };
        */

        var query = Flights.Where(f => f.Plane.Equals(plane)).Select(f => new { f.Destination, f.FlightDate });


        foreach (var item in query)
        {
            Console.WriteLine(item.Destination + " , " + item.FlightDate);
        }
    }
    public int ProgrammedFlightNumber(DateTime startDate)
    {
        var query = from f in Flights
                    where f.FlightDate > startDate
                    && f.FlightDate < startDate.AddDays(7)
                    select f;
        return query.Count();
    }

    public double DurationAverage(string destination)
    {
        /*return (from f in Flights
                where f.Destination.Equals(destination)
                select f.EstimatedDuration).Average();*/

        return Flights.Where(f => f.Destination.Equals(destination)).Average(f => f.EstimatedDuration); 

    }

    public IEnumerable<Flight> OrderedDurationFlights()
    {
        /*return from f in Flights
               orderby f.EstimatedDuration descending
               select f;
         */

        return Flights.OrderByDescending(f => f.EstimatedDuration);
    }

    public IList<Passenger> SeniorTravellers(Flight flight)
    {
        /*return (from p in flight.Passengers
                where p is Traveller  // tjs de type passenger
                orderby p.BirthDate ascending
                select p).Take(3).ToList();
        */

        return flight.Passengers.Where(p => p is Traveller).OrderBy(p => p.BirthDate).Take(3).ToList();
    }
    public IList<Traveller> SeniorTravellers2(Flight flight)
    {
        return (from p in flight.Passengers.OfType<Traveller>() // type travellers
                orderby p.BirthDate ascending
                select p).Take(3).ToList();

        
    }
    public IList<string> SeniorTravellersNationalities(Flight flight)
    {
        return (from p in flight.Passengers.OfType<Traveller>() // type travellers
                orderby p.BirthDate ascending
                select p.Nationality).Take(3).ToList();
    }

    public void ShowDestinationGroupedFlights()
    {
        /*  var query = from f in Flights
                      group f by f.Destination;
          foreach (var item in query)
          {
              Console.WriteLine(" Destination : " + item.Key);
              foreach (var item2 in item)
              {
                  Console.WriteLine(" Décollage : " + item2.FlightDate);
              }
          }
        */ 

        var query1 = Flights.GroupBy(f => f.Destination).ToList();

        query1.ForEach(item1 =>{
        Console.WriteLine("Destination:"+item1.Key);
            item1.ToList().ForEach(item2 => Console.WriteLine("Decolage:" + item2.FlightDate));


    });

        


    }

    public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
    {
        return from f in Flights
               group f by f.Destination;
    }
}
