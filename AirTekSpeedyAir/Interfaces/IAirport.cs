using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface IAirport
    {
         string Code { get; set; }
         ICity City { get; set; }


    }
}
