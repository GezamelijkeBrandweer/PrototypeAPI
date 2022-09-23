using gb_api.Server.Domain;
using OpenMeteoAPILib;

namespace gb_api.Server.Application;

public class WeerService
{
    public async Task<Weersinformatie> GetWeerFromLocatie(double? latitude, double? longitude)
    {
        var jsonData = await OpenMeteo.GetWeerInfo(latitude, longitude);
        
        return new Weersinformatie(
            jsonData["hourly"]["time"].ToString(),
            jsonData["hourly"]["temperature_2m"].ToString(), 
            jsonData["hourly"]["relativehumidity_2m"].ToString(), 
            jsonData["hourly"]["rain"].ToString(), 
            jsonData["hourly"]["windspeed_10m"].ToString(), 
            jsonData["hourly"]["winddirection_10m"].ToString(), 
            jsonData["hourly"]["windgusts_10m"].ToString());
    }
}