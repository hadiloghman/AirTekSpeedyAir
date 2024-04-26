using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Airport : IAirport
    {
        public Airport(ICity city, string code)
        {
            this.Code = code;
            this.City = city;
        }
      
        public string Code { get; set; }
        public ICity City { get; set; }


    }
}
