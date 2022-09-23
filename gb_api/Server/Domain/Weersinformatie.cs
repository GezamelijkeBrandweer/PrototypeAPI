using System.ComponentModel.DataAnnotations;

namespace gb_api.Server.Domain;

public class Weersinformatie
{
    public Weersinformatie(string? time, string? temperature, string? humidity, string? rain,
        string? windspeed, string? winddirection, string? windgusts)
    {
        Time = time;
        Temperature = temperature;
        Humidity = humidity;
        Rain = rain;
        Windspeed = windspeed;
        Winddirection = winddirection;
        Windgusts = windgusts;
    }
    
    public Weersinformatie(){}
    
    public long Id { get; set; }

    public string? Time { get; set; }

    public string? Temperature { get; set; }

    public string? Humidity { get; set; }

    public string? Rain { get; set; }

    public string? Windspeed { get; set; }

    public string? Winddirection { get; set; }

    public string? Windgusts { get; set; }
}