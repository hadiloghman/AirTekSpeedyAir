using AirTekSpeedyAir.Interfaces;
using AirTekSpeedyAir.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Flight : IFlight
    {

        public string FlightNumber { get; set; }
        public IAirport AirportDeparture { get; set; }
        public IAirport AirportArrival { get; set; }
        public IAirline Airline { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Capacity { get; set; } = 20;

        List<IFlightHistory> _history = new List<IFlightHistory>();
        public List<IFlightHistory> History => _history;

        public void AddAction(enumFlightStatus status, DateTime time) => this._history.Add(new FlightHistory { Action = status, ActionTime = time });

    }
}
