namespace gb_api.Incident.Domain;

public class Locatie
{
    public string? Postcode { get; set; }
    public string? Straat { get; set; }
    public int? Huisnummer { get; set; }
    public string? Woonplaats { get; set; }
    public double? Latitude  { get; set; }
    public double? Longitude  { get; set; }

    public Locatie(string? postcode, string? straat, int? huisnummer, string? woonplaats, double? latitude, double? longitude)
    {
        Postcode = postcode;
        Straat = straat;
        Huisnummer = huisnummer;
        Woonplaats = woonplaats;
        Latitude = latitude;
        Longitude = longitude;
    }
}