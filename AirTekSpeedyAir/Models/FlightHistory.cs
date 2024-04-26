using AirTekSpeedyAir.Interfaces;
using AirTekSpeedyAir.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class FlightHistory : IFlightHistory
    {
        public DateTime ActionTime { get; set; }
        public enumFlightStatus Action { get; set; }

    }
}
