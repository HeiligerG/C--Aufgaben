namespace WitzeAPI;

public class WitzAusgabe
{
    public void GibWitzAus(APICall witz)
    {
        Console.WriteLine($"Witz: {witz.text}");
        // Console.WriteLine($"Sprache: {witz.language}"); 
    }
}