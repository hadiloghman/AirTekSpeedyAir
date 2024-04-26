using AirTekSpeedyAir.Models;


Console.WriteLine("***************USER STORY #1*********************");

Console.WriteLine(Repo.Instance.flightItineraryRepo.LoadItineraries());

OrderRepo orders = new OrderRepo();
orders.LoadJson();
foreach (var flightItinerary in Repo.Instance.flightItineraryRepo)
{
    flightItinerary.AddOrders(orders.OrderBy(o => o.Priority).Where(o => o.AirportDestination == flightItinerary.AirportArrival && o.FlightItinerary == null).Take(flightItinerary.RemainCapacity).ToList());
}
Console.WriteLine("***************USER STORY #2*********************");
Console.WriteLine(orders.LoadOrdersSchedules());
Console.ReadLine();