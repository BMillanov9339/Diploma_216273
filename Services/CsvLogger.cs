using System;
using System.IO;

namespace diploma_216273.Services
{
    public class CsvLogger
    {
        public static void LogMeasurement(string room, double temp, double hum)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dataDirectory = Path.Combine(baseDirectory, "data");
            Directory.CreateDirectory(dataDirectory);

            string filePath = Path.Combine(dataDirectory, $"{DateTime.Now:yyyy-MM-dd}.csv");
            string timeString = DateTime.Now.ToString("HH:mm");
            string line = $"{timeString}:::{room}:::{temp:F2}:::{hum:F2}";

            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (!fileExists)
                    writer.WriteLine("Time,Room,Temperature (°C),Humidity (%)");

                writer.WriteLine(line);
            }
        }
    }
}
