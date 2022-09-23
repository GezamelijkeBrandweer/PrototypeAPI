using System.Text.Json.Nodes;

namespace BagAPILib;

public static class BagApiCalls
{
    private const string BagKey = "l7e6e43c660b6f46d6a0c7ddd72a159030";
    private static readonly HttpClient BagClient = new()
    {
        BaseAddress = new Uri("https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/"),
    };

    // gebruik adressenUitGebreid BAG API
    public static async Task<JsonNode> TestAdressenBag(string postcode, int huisnummer)
    {
        BagClient.DefaultRequestHeaders.Add("X-Api-Key",BagKey);
        BagClient.DefaultRequestHeaders.Add("Accept-Crs", "epsg:28992");
        using var response = await BagClient.GetAsync($"adressenuitgebreid?postcode={postcode}&huisnummer={huisnummer}&exacteMatch=true");
        
        response.EnsureSuccessStatusCode();
        var jsoNresponse = await response.Content.ReadAsStringAsync();
        var document = JsonNode.Parse(jsoNresponse);
        var adres = document["_embedded"]["adressen"];
        return adres;
    }

}