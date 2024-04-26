using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class FlightItineraryRepo : List<IFlightItinerary>
    {

        public string LoadItineraries()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= this.Count; i++)
            {
                stringBuilder.Append($"Flight: {i}").AppendLine(this[i - 1].ToString());
            }
            return stringBuilder.ToString();
        }
    }

}
