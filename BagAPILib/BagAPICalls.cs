using System.Text.Json.Nodes;

namespace BagAPILib;

public static class BagApiCalls
{
    private const string BagKey = "l7bcbd7327691b4319b2e96b6bda713d7d";
    private static readonly HttpClient BagClient = new()
    {
        BaseAddress = new Uri("https://api.bag.acceptatie.kadaster.nl/lvbag/individuelebevragingen/v2/"),
    };

    // gebruik adressenUitGebreid BAG API
    public static async Task<JsonNode> TestAdressenBag(string postcode, int huisnummer)
    {
        BagClient.DefaultRequestHeaders.Add("X-Api-Key",BagKey);
        BagClient.DefaultRequestHeaders.Add("Accept-Crs", "epsg:28992");
        using var response = await BagClient.GetAsync($"adressenuitgebreid?postcode={postcode}&huisnummer={huisnummer}&exacteMatch=true");
        
        response.EnsureSuccessStatusCode();
        var jsoNresponse = await response.Content.ReadAsStringAsync();
        var document = JsonNode.Parse(jsoNresponse)!;
        //Met deze api call kunnen er ook meerdere adressen opgehaald worden hier maakt deze methode niet gebruik van vandaar de [0]
        var adres = document["_embedded"]!["adressen"][0]!;
        return adres;
    }

}