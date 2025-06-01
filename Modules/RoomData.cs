using diploma_216273.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma_216273.Modules
{
    public class RoomData
    {
        public MeasurementBuffer TempHistory { get; } = new MeasurementBuffer();
        public MeasurementBuffer HumHistory { get; } = new MeasurementBuffer();
    }
}
