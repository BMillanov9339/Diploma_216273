using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using diploma_216273.Services;
using diploma_216273.Settings;

namespace diploma_216273.Managers
{
    //Този модул е междинният между интерфейса и данните. Тук минава голяма част от логиката, която не може да се реши в съответния модул.

   public class RoomManager
    {
        private const int timeMinute = 60;
        private int secondCounter = 0;

        private Timers timers;

        private double tempVal;
        private double humVal;

        public bool labelHeatFlag = false;
        public bool labelVentFlag = false;

        private const int MaxPoints = 60;

        private Dictionary<string, Queue<double>> tempQueues = new Dictionary<string, Queue<double>>();
        private Dictionary<string, Queue<double>> humQueues = new Dictionary<string, Queue<double>>();

        public event Action<string, double, double> OnRoomSensorUpdate;
        public event Action<string, double[], double[]> OnChartDataUpdate;
        public event Action<string, double[], double[]> OnRoomChartDataUpdate;

        private Dictionary<string, RoomController> roomControllers = new Dictionary<string, RoomController>();

        public Dictionary<string, bool> HeatStatus { get; } = new Dictionary<string, bool>();
        public Dictionary<string, bool> VentStatus { get; } = new Dictionary<string, bool>();

        //Задава начални стойности за всяко помещемие
        public RoomManager()
        {
            timers = new Timers();

            foreach (var room in SettingsStore.RoomSettingsDict.Keys)
            {
                roomControllers[room] = new RoomController();
                HeatStatus[room] = false;
                VentStatus[room] = false;
                tempQueues[room] = new Queue<double>();
                humQueues[room] = new Queue<double>();
            }

            StartMonitorLoop();
        }

        //Тези масиви отговарят за графичното изобразяване на информацията ---------------------- 
        public void AddMeasurement(string room, double temp, double hum)
        {
            if (!tempQueues.ContainsKey(room) || !humQueues.ContainsKey(room))
                return;

            AddToQueue(tempQueues[room], temp);
            AddToQueue(humQueues[room], hum);

       
            OnRoomChartDataUpdate?.Invoke(room, tempQueues[room].ToArray(), humQueues[room].ToArray());
            OnChartDataUpdate?.Invoke(room, tempQueues[room].ToArray(), humQueues[room].ToArray());
        }

        private void AddToQueue(Queue<double> queue, double value)
        {
            if (queue.Count >= MaxPoints)
                queue.Dequeue();
            queue.Enqueue(value);
        }

        //Всеки сензор има допустими стойности, според документацията. Тук съм сложил приемливи
       void checkLimits()
        {
            if (tempVal < -20.0 || tempVal > 120.0)
            {
                tempVal = 0;
            }

            if (humVal < 0.0 || humVal > 85.0)
            {
                    humVal = 0;
            }
        }


        //Тази функция взема данните от другите модули, за да ги визуализира в интерфейса.
        // Адресът на контролера е по SNMP. Специфичен е за всяко устройство, и се взема от документацията.
        private async void StartMonitorLoop()
        {
            while (true)
            {
                await Task.Delay(100);

                if (timers.getTimerFlag())
                {
                    //SensorReader reader = new SensorReader("172.16.1.200", "public");
                   // Dictionary<string, (string Heat, string Vent)> roomRelays = new Dictionary<string, (string, string)>
{
                    //{ "Room1", ("Room1_Heat", "Room1_Vent") },
                   // { "Room2", ("Room2_Heat", "Room2_Vent") },
                    // Add more rooms as needed
};
                    //var data = reader.Read();

                    foreach (var room in roomControllers.Keys)
                        {
                            tempVal = RandomNumbersGo.GetRandomDouble() * 100;
                            humVal = RandomNumbersGo.GetRandomDouble() * 100;

                            //Оставил съм вземането на произволно число с цел демонстрация
                            //tempVal = data[room].Temperature/1000;
                            //humVal = data[room].Humidity/1000;

                            checkLimits();
                        

                            AddMeasurement(room, tempVal, humVal);

                            OnRoomSensorUpdate?.Invoke(room, tempVal, humVal);
                        }

                        foreach (var kvp in roomControllers)
                        {
                            string room = kvp.Key;
                            RoomController controller = kvp.Value;

                            if (!SettingsStore.RoomSettingsDict.TryGetValue(room, out RoomSettings settings))
                                continue;

                            controller.Update(tempVal, humVal, settings);

                            HeatStatus[room] = controller.IsHeatOn;
                            VentStatus[room] = controller.IsVentOn;

                        /*
                        if (roomRelays.TryGetValue(room, out var relays))
                        {
                            relayController.SetRelayState(relays.Heat, controller.IsHeatOn);
                            relayController.SetRelayState(relays.Vent, controller.IsVentOn);
                        }
                        */


                    }

                    secondCounter++;
                    if (secondCounter >= timeMinute)
                    {
                        secondCounter = 0;

                        foreach (var room in roomControllers.Keys)
                        {
                            CsvLogger.LogMeasurement(room, tempVal, humVal);
                        }
                    }
                }
            }
       }
    }
}
