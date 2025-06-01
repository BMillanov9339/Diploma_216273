using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using diploma_216273.Services;
using diploma_216273.Settings;

namespace diploma_216273.Modules
{
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

        // Restored global and room-specific events
        public event Action<string, double, double> OnRoomSensorUpdate;
        public event Action<string, double[], double[]> OnChartDataUpdate;
    public event Action<string, double[], double[]> OnRoomChartDataUpdate;

    private Dictionary<string, RoomController> roomControllers = new Dictionary<string, RoomController>();

    public Dictionary<string, bool> HeatStatus { get; } = new Dictionary<string, bool>();
    public Dictionary<string, bool> VentStatus { get; } = new Dictionary<string, bool>();

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

    public void AddMeasurement(string room, double temp, double hum)
    {
        if (!tempQueues.ContainsKey(room) || !humQueues.ContainsKey(room))
            return;

        AddToQueue(tempQueues[room], temp);
        AddToQueue(humQueues[room], hum);

        // Trigger both global and room-specific chart events
        OnRoomChartDataUpdate?.Invoke(room, tempQueues[room].ToArray(), humQueues[room].ToArray());
        OnChartDataUpdate?.Invoke(room, tempQueues[room].ToArray(), humQueues[room].ToArray());
    }

    private void AddToQueue(Queue<double> queue, double value)
    {
        if (queue.Count >= MaxPoints)
            queue.Dequeue();
        queue.Enqueue(value);
    }

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
    private async void StartMonitorLoop()
    {
        while (true)
        {
            await Task.Delay(100);

            if (timers.getTimerFlag())
            {
                    SensorReader reader = new SensorReader("172.16.1.200", "public");
                    var data = reader.Read();

                    foreach (var room in roomControllers.Keys)
                    {
                        // tempVal = RandomNumbersGo.GetRandomDouble() * 100;
                        tempVal = data[room].Temperature/1000;
                        humVal = data[room].Humidity/1000;

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

                    if (room == "Room 1")
                    {
                        labelHeatFlag = controller.IsHeatOn;
                        labelVentFlag = controller.IsVentOn;
                    }

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
