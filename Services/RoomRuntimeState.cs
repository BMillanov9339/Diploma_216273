using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma_216273.Services
{
    public class RoomRuntimeState
    {
        public bool IsHeatOn { get; set; }
        public bool IsVentOn { get; set; }

        public double CurrentTemperature { get; set; }
        public double CurrentHumidity { get; set; }

        public int HeatCycleElapsedMinutes { get; set; }
        public int VentCycleElapsedMinutes { get; set; }

        public bool HeatCycleOn { get; set; }
        public bool VentCycleOn { get; set; }
    }
}