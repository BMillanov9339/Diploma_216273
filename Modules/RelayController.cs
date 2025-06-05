using System;
using System.Collections.Generic;
using System.Net;
using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;

namespace diploma_216273.Modules
{
    public class RelayController
    {
        private readonly string _ip;
        private readonly string _readCommunity;
        private readonly string _writeCommunity;

        private readonly Dictionary<string, ObjectIdentifier> _relayOids;

        public RelayController(string ip, string readCommunity = "public", string writeCommunity = "private")
        {
            _ip = ip;
            _readCommunity = readCommunity;
            _writeCommunity = writeCommunity;

            _relayOids = new Dictionary<string, ObjectIdentifier>
        {
            { "Relay1", new ObjectIdentifier("1.3.6.1.4.1.12345.3.1.0") },
            { "Relay2", new ObjectIdentifier("1.3.6.1.4.1.12345.3.2.0") }
        };
        }

        public bool GetRelayState(string relayName)
        {
            if (!_relayOids.TryGetValue(relayName, out var oid))
                throw new ArgumentException($"Unknown relay name: {relayName}");

            var result = Messenger.Get(VersionCode.V2,
                new IPEndPoint(IPAddress.Parse(_ip), 161),
                new OctetString(_readCommunity),
                new List<Variable> { new Variable(oid) },
                5000);

            return int.TryParse(result[0].Data.ToString(), out int value) && value == 1;
        }

        public void SetRelayState(string relayName, bool on)
        {
            if (!_relayOids.TryGetValue(relayName, out var oid))
                throw new ArgumentException($"Unknown relay name: {relayName}");

            var value = new Integer32(on ? 1 : 0);

            Messenger.Set(VersionCode.V2,
                new IPEndPoint(IPAddress.Parse(_ip), 161),
                new OctetString(_writeCommunity),
                new List<Variable> { new Variable(oid, value) },
                5000);
        }
    }
}
