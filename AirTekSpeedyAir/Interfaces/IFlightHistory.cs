using AirTekSpeedyAir.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Interfaces
{
    public interface IFlightHistory
    {
         DateTime ActionTime { get; set; }
         enumFlightStatus Action { get; set; }

    }
}
