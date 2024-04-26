using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Airline : IAirline
    {
        public  ICity City { get; set; }
        public required string Name { get; set; }
        
    }
}
