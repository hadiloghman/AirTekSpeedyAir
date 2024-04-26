using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class City:ICity
    {
        public City(ICountry country, string name)
        {
            this.Country = country;
            this.Name = name;
        }
        public ICountry Country { get; set; }
        public string Name { get; set; }
    }
}
