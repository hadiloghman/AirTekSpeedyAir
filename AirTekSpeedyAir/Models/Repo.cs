using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Repo
    {
        public static Repo _repo = null;
        public static Repo Instance
        {
            get
            {
                if(_repo == null )
                {
                    _repo = new Repo();
                }
                return _repo;
            }
        }

        public Repo()
        {
            ICountry country = new Country("Canada");
            this.Countries = new List<ICountry> { country };

            this.Cities = new List<ICity>() {
    new City(country, "Montreal"),
    new City(country, "Toronto"),
    new City(country, "Calgary"),
    new City(country, "Vancouver")
};


            this.Airports = new List<IAirport>()
{
    new Airport(Cities[0],"YUL"),
    new Airport(Cities[1],"YYZ"),
    new Airport(Cities[2],"YYC"),
    new Airport(Cities[3],"YVR")
};

            this.flightItineraryRepo = new FlightItineraryRepo();

            this.flightItineraryRepo.Add((new FlightItinerary()).AddFlight(new Flight
            {
                FlightNumber = Guid.NewGuid().ToString(),
                AirportArrival = this.Airports[1],
                AirportDeparture = this.Airports[0],
                DepartureTime = DateTime.Now.Date.AddHours(12)
            }));

            this.flightItineraryRepo.Add((new FlightItinerary()).AddFlight(new Flight
            {
                FlightNumber = Guid.NewGuid().ToString(),
                AirportArrival = this.Airports[2],
                AirportDeparture = this.Airports[0],
                DepartureTime = DateTime.Now.Date.AddHours(12)
            }));

            this.flightItineraryRepo.Add((new FlightItinerary()).AddFlight(new Flight
            {
                FlightNumber = Guid.NewGuid().ToString(),
                AirportArrival = this.Airports[3],
                AirportDeparture = this.Airports[0],
                DepartureTime = DateTime.Now.Date.AddHours(12)
            }));

            this.flightItineraryRepo.AddRange(flightItineraryRepo.Select(o =>
            ((IFlightItinerary)new FlightItinerary()).AddFlight(new Flight()
            {
                FlightNumber = Guid.NewGuid().ToString(),
                DepartureTime = DateTime.Now.Date.AddDays(1),
                AirportArrival = o.Flights[0].AirportDeparture,
                AirportDeparture = o.Flights[0].AirportArrival
            })).ToList());

            flightItineraryRepo.AddRange(flightItineraryRepo.Select(o =>
            ((IFlightItinerary)new FlightItinerary()).AddFlight(new Flight()
            {
                FlightNumber = Guid.NewGuid().ToString(),
                DepartureTime = o.Flights[0].DepartureTime.AddDays(1),
                AirportArrival = o.Flights[0].AirportArrival,
                AirportDeparture = o.Flights[0].AirportDeparture
            })).ToList());

        }

        public List<ICountry> Countries { get; set; }
        public List<ICity> Cities { get; set; }
        public List<IAirport> Airports { get; set; }

        public FlightItineraryRepo flightItineraryRepo { get; set; }
    }
}
