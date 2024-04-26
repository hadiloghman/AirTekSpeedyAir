using AirTekSpeedyAir.Interfaces;
using AirTekSpeedyAir.Shared.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class FlightItinerary : IFlightItinerary
    {
        #region properties
        public long Id { get; set; }
        public List<IFlight> Flights { get; set; } = new List<IFlight>();
        public List<IOrder> Orders { get; set; }
        public bool Canceled { get; private set; }
        public string CancelDescription { get; private set; }

        public int RemainCapacity
        {
            get
            {
                int minCapacity = this.Flights.Min(o => o.Capacity);
                return minCapacity - (this.Orders?.Count() ?? 0);
            }
        }

        public IAirport AirportDeparture
        {
            get
            {
                return this.Flights.First().AirportDeparture;
            }
        }
        public IAirport AirportArrival
        {
            get
            {
                return this.Flights.Last().AirportArrival;
            }
        }
        #endregion

        #region functions
        public IFlightItinerary AddFlight(IFlight flight)
        {
            this.Flights.Add(flight);
            return this;
        }
        public void AddFlights(List<IFlight> flights)
        {
            if (flights == null)
                throw new ArgumentNullException(nameof(flights));
            this.Flights.AddRange(flights);
        }

        public void AddOrder(IOrder order)
        {
            if (this.Orders == null) this.Orders = new List<IOrder>();
            if (this.RemainCapacity <= 0) throw new("There is no more Capacity to add Order");
            this.Orders.Add(order);
            order.FlightItinerary = this;
        }

        public void AddOrders(List<IOrder> orders)
        {
            foreach (var order in orders)
            {
                AddOrder(order);
            }
        }

        public void CancelItinerary(string CancelDescription)
        {
            this.Canceled = true;
            this.CancelDescription = CancelDescription;
        }

        public string ToString()
        {
            if (this.Flights.Count == 0) return "";
            return
                " Departure: " + this.Flights[0].AirportDeparture.City.Name
                + ", Arrival: " + this.Flights.Last().AirportArrival.City.Name
                + ", Day:" + (this.Flights.Last().DepartureTime.Subtract(DateTime.Now.Date).Days + 1);
        }
        #endregion
    }
}
