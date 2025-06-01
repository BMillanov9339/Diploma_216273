using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using diploma_216273.Settings;

namespace diploma_216273.Services
{

    public static class SettingsStore
    {
        public static Dictionary<string, RoomSettings> RoomSettingsDict { get; } = new Dictionary<string, RoomSettings>();

        public static void Load()
        {
            if (File.Exists(SettingsFilePath))
            {
                var json = File.ReadAllText(SettingsFilePath);
                var loadedSettings = JsonConvert.DeserializeObject<Dictionary<string, RoomSettings>>(json);

                if (loadedSettings != null)
                {
                    RoomSettingsDict.Clear();
                    foreach (var kvp in loadedSettings)
                        RoomSettingsDict[kvp.Key] = kvp.Value;
                }
                else
                {
                    // Optionally initialize defaults if file is missing or corrupted
                    InitializeDefaults();
                }
            }
            else
            {
                InitializeDefaults();
            }
        }

        private static void InitializeDefaults()
        {
            RoomSettingsDict.Clear();
            RoomSettingsDict["Room 1"] = new RoomSettings();
            RoomSettingsDict["Room 2"] = new RoomSettings();
            //RoomSettingsDict["Room 3"] = new RoomSettings();
            //RoomSettingsDict["Room 4"] = new RoomSettings();
        }

        public static string SettingsFilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

        public static void Save()
        {
            string json = JsonConvert.SerializeObject(RoomSettingsDict, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }
    }


}
