namespace gb_api.Server.Domain;

public class Locatie
{
    public Locatie(string? postcode, string? straat, int? huisnummer, string? woonplaats, double? latitude,
        double? longitude)
    {
        Postcode = postcode;
        Straat = straat;
        Huisnummer = huisnummer;
        Woonplaats = woonplaats;
        Latitude = latitude;
        Longitude = longitude;
    }
    public long Id { get; set; }
    public string? Postcode { get; set; }
    public string? Straat { get; set; }
    public int? Huisnummer { get; set; }
    public string? Woonplaats { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    
}