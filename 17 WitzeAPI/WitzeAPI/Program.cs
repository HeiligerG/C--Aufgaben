namespace WitzeAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://witzapi.de/api/")
            };

            var witzVerarbeitung = new WitzVerarbeitung();
            var witzAusgabe = new WitzAusgabe();

            while (true)
            {
                var witz = await witzVerarbeitung.HoleWitz(client);
                witzAusgabe.GibWitzAus(witz);

                Console.WriteLine("Möchten Sie einen weiteren Witz? (j/n)");
                if (Console.ReadLine()?.ToLower() != "j")
                    break;
            }
        }
    }
}

// API: https://witzapi.de/api/joke/
// Witze durch -- hohlen
// witze verarbeiten als obj. 
// witze ausgeben und fragen ob nächsten witz
// klassen: APICall, WitzVerarbeitung, WitzAusgabe
// Methoden:GetAPI , MakeWitz         , GibWitzAus

//Als erstes CallAPI - dan verarbeitung - dann ausgabe - wobei eigentlich nur die verarbeitung ausgelagert werden sollte von der Grösse her!!!