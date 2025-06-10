using diploma_216273.Settings;

namespace diploma_216273.Managers
{
    //Този модул контролира промяната на интерфейса на база на режимите на работа.
    //В последствие, тези флагове ще се използват и от SensorReader за релетата, или ще направя нов модул, напр. RelayControl
    public class RoomController
    {
        private int heatTimerCounter = 0;
        private int ventTimerCounter = 0;

        private bool heatToggleState = false;
        private bool ventToggleState = false;

        public bool IsHeatOn { get; private set; }
        public bool IsVentOn { get; private set; }

        public void Update(double currentTemp, double currentHum, RoomSettings settings)
        {
            if (settings.Mode == OperationMode.Timed)
            {
                IsHeatOn = UpdateTimed(ref heatTimerCounter, settings.TimedSettings.tempTimeOn, settings.TimedSettings.tempTimeOff, ref heatToggleState);
                IsVentOn = UpdateTimed(ref ventTimerCounter, settings.TimedSettings.humTimeOn, settings.TimedSettings.humTimeOff, ref ventToggleState);
            }
            else if (settings.Mode == OperationMode.Maintain)
            {
                IsHeatOn = currentTemp < settings.MaintainSettings.targetTemperature;
                IsVentOn = currentHum < settings.MaintainSettings.targetHumidity;
            }
        }

        private bool UpdateTimed(ref int counter, int timeOn, int timeOff, ref bool toggle)
        {
            counter++;

            if (toggle && counter >= timeOn)
            {
                toggle = false;
                counter = 0;
            }
            else if (!toggle && counter >= timeOff)
            {
                toggle = true;
                counter = 0;
            }

            return toggle;
        }
    }

}
