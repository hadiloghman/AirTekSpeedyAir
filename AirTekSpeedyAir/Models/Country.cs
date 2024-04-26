using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class Country : ICountry
    {
        public Country(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; } = "";
    }
}
