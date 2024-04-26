using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface IOrder
    {
        IAirport AirportDestination { get; set; }
        int Priority { get; set; }
        IFlightItinerary FlightItinerary { get; set; }

        string ToString();

    }
}
