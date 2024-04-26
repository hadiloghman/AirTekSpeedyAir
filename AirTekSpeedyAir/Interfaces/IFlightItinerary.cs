using AirTekSpeedyAir.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface IFlightItinerary
    {

        #region properties
        long Id { get; set; }
        List<IFlight> Flights { get; set; }
        List<IOrder> Orders { get; set; }
        bool Canceled { get; }
        string CancelDescription { get; }
        int RemainCapacity { get; }
        IAirport AirportDeparture { get; }
        IAirport AirportArrival { get; }
        #endregion

        #region functions
        IFlightItinerary AddFlight(IFlight flight);
        void AddFlights(List<IFlight> flights);
        void AddOrder(IOrder order);
        void AddOrders(List<IOrder> orders);
        void CancelItinerary(string CancelDescription);

        string ToString();
        #endregion
    }
}
