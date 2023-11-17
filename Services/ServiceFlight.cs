using AMS.ApplicationCore.Domain;
using AMS.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; }= new List<Flight>();

    }
}
