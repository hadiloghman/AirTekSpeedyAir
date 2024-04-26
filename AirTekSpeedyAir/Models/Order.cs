using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Order : IOrder
    {
        public IAirport AirportDestination { get; set; }
        public int Priority { get; set; }

        public IFlightItinerary FlightItinerary { get; set; }

        public string ToString()
        {
            return
                " Order: order-" + this.Priority.ToString("D3")
                + ",flightNumber: " + (this.FlightItinerary?.ToString() ?? "Not Scheduled");
        }
    }
}
