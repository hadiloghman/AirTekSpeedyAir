using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface ICity
    {
         ICountry Country { get; set; }
         string Name { get; set; }
    }
}
