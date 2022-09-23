using BagAPILib;
using gb_api.Server.Domain;

namespace gb_api.Server.Application;

public class LocatieService
{
    public async Task<Locatie> GetLocatieFromPostcodeHuisnummer(string postcode, int huisnummer)
    {
        var jsonData = await BagApiCalls.TestAdressenBag(postcode, huisnummer);
        return new Locatie(
            huisnummer: huisnummer, 
            postcode: postcode,
            woonplaats: jsonData["woonplaatsNaam"].ToString(), 
            straat: jsonData["korteNaam"].ToString(),
            latitude: double.Parse(jsonData["adresseerbaarObjectGeometrie"]["punt"]["coordinates"][0].ToString()),
            longitude: double.Parse(jsonData["adresseerbaarObjectGeometrie"]["punt"]["coordinates"][1].ToString()));
    }
}