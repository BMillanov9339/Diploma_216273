//Съединява другите модули за настройки

namespace diploma_216273.Settings
{
    public class RoomSettings
    {
        public OperationMode Mode { get; set; } = OperationMode.Timed;

        public TimedSettings TimedSettings { get; set; } = new TimedSettings();
        public MaintainSettings MaintainSettings { get; set; } = new MaintainSettings();
    }
}
