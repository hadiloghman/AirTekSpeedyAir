using AirTekSpeedyAir.Models;
using AirTekSpeedyAir.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface IFlight
    {
         string FlightNumber { get; set; }
         IAirport AirportDeparture { get; set; }
         IAirport AirportArrival { get; set; }
         IAirline Airline { get; set; }
         DateTime DepartureTime { get; set; }
         DateTime ArrivalTime { get; set; }
         int Capacity { get; set; }
         List<IFlightHistory> History { get; }

         void AddAction(enumFlightStatus status, DateTime time);
    }
}
