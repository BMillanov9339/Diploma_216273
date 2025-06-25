using Lextm.SharpSnmpLib.Messaging;
using Lextm.SharpSnmpLib;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace diploma_216273.Services
{
    //Настройки на контролера по SNMP. Към половината от тези адреси няма свързани сензори, но това просто означава, че нямам стойности.
    //Без валидни адреси, програмата се чупи
    public class RoomReading
    {
        public string RoomName { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }

    public class SensorReader
    {
        private readonly string _ip;
        private readonly string _community;


        private readonly List<(string Oid, string Room, string Metric)> _oidMap;

        public SensorReader(string ip, string community)
        {
            _ip = ip;
            _community = community;

            _oidMap = new List<(string, string, string)>
        {
            ("1.3.6.1.4.1.38783.3.3.1.1.1.0", "Room 1", "Temp"),
            ("1.3.6.1.4.1.38783.3.3.1.1.2.0", "Room 1", "Humidity"),
            ("1.3.6.1.4.1.38783.3.3.1.2.1.0", "Room 2", "Temp"),
            ("1.3.6.1.4.1.38783.3.3.1.2.2.0", "Room 2", "Humidity"),
           // ("1.3.6.1.4.1.38783.3.3.1.3.1.0", "Room 3", "Temp"),
           // ("1.3.6.1.4.1.38783.3.3.1.3.2.0", "Room 3", "Humidity"),
            //("1.3.6.1.4.1.38783.3.3.1.4.1.0", "Room 4", "Temp"),
           // ("1.3.6.1.4.1.38783.3.3.1.4.2.0", "Room 4", "Humidity")
        };
        }

        public Dictionary<string, RoomReading> Read()
        {
            var oidToMeta = _oidMap.ToDictionary(x => new ObjectIdentifier(x.Oid), x => (x.Room, x.Metric));

            var variables = oidToMeta.Keys.Select(oid => new Variable(oid)).ToList();

            var result = Messenger.Get(VersionCode.V2,
                                       new IPEndPoint(IPAddress.Parse(_ip), 161),
                                       new OctetString(_community),
                                       variables,
                                       5000);

            var readings = new Dictionary<string, RoomReading>();

            foreach (var variable in result)
            {
                if (!oidToMeta.TryGetValue(variable.Id, out var meta))
                    continue;

                if (!readings.ContainsKey(meta.Room))
                    readings[meta.Room] = new RoomReading { RoomName = meta.Room };

                if (float.TryParse(variable.Data.ToString(), out float val))
                {
                    if (meta.Metric == "Temp") readings[meta.Room].Temperature = val;
                    else if (meta.Metric == "Humidity") readings[meta.Room].Humidity = val;
                }
            }

            return readings;
        }
    }
}

