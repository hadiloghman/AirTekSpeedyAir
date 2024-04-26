using AirTekSpeedyAir.Interfaces;
using AirTekSpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Helper
{
    public class OrderJsonReader
    {
        public static string ReadJsonFile(string jsonPath)
        {
            return File.ReadAllText(jsonPath);
        }

        public static List<IOrder> LoadOrdersFromJsonString(string jsonString)
        {
            List<IOrder> lstOrders = new List<IOrder>();
            var dic = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
            string destinationAirportCode;
            IAirport airport;
            foreach (var item in dic)
            {
                destinationAirportCode = item.Value.GetProperty("destination").GetString();
                airport = Repo.Instance.Airports.FirstOrDefault(o => o.Code == destinationAirportCode);
                if (airport == null)
                {
                    //throw new Exception($"Destination {destinationAirportCode} does not exist in the list");
                }
                else
                    lstOrders.Add(new Order { Priority = int.Parse(item.Key.Replace("order-", "")), AirportDestination = airport });
            }
            return lstOrders;
        }
    }
}
