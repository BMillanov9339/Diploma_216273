using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma_216273.Settings
{
    public class RoomSettings
    {
        public OperationMode Mode { get; set; } = OperationMode.Timed;

        public TimedSettings TimedSettings { get; set; } = new TimedSettings();
        public MaintainSettings MaintainSettings { get; set; } = new MaintainSettings();
    }
}
