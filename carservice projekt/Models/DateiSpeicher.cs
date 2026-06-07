using carservice_projekt.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace carservice_projekt
{
    public class DateiSpeicher
    {
        public void Speichern(List<Fahrzeug> fahrzeuge)
        {
            string json = JsonSerializer.Serialize(fahrzeuge);

            File.WriteAllText("fahrzeuge.json", json);
        }
    }
}