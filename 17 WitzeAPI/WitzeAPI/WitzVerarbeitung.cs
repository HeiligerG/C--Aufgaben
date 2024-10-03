using System.Net.Http.Json;

namespace WitzeAPI;

public class WitzVerarbeitung
{ 
    public async Task<APICall> HoleWitz(HttpClient client)
    { 
        try
        { 
            var witze = await client.GetFromJsonAsync<List<APICall>>("joke");
            return witze?.FirstOrDefault() ?? new APICall() { text = "Kein Witz verfügbar", language = "de" };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Abrufen des Witzes: {ex.Message}");
            return new APICall() { text = "Fehler beim Abrufen des Witzes", language = "de" };
        }
    }
}