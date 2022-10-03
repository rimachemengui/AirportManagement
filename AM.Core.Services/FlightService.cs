using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;


namespace AM.Core.Services
{
    public class FlightService : IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                .Select(f => f.FlightDate)
                .ToList();
        }

        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            return Flights.Where(fType => fType.Get )
                .Select()
                .ToList();
        }
    }
}
