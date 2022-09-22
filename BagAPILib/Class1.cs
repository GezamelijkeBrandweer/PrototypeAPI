using System.Text.Json.Nodes;

namespace BagAPILib;

public static class Class1
{
    
    // gebruik adressenUitGebreid BAG API
    static async void testAdressenBAG(string postcode, int huisnummer)
    {


        using HttpClient todoClient = new()
        {
            BaseAddress = new Uri("https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/")
        };
        todoClient.DefaultRequestHeaders.Add("X-Api-Key","l7e6e43c660b6f46d6a0c7ddd72a159030");
        todoClient.DefaultRequestHeaders.Add("Accept-Crs", "epsg:28992");
        using var response = await todoClient.GetAsync($"adressenuitgebreid?postcode=1261VC&huisnummer=15&exacteMatch=true");
        response.EnsureSuccessStatusCode();
        var JSONresponse = await response.Content.ReadAsStringAsync();
        var document = JsonNode.Parse(JSONresponse);

        var adres = document["_embedded"]["adressen"][0];
        Console.WriteLine(adres);
        
    }
    
}