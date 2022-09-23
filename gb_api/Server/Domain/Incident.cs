namespace gb_api.Server.Domain;

public class Incident
{
    public Incident(long id, string? name, Locatie locatie, Weersinformatie weersinformatie)
    {
        Id = id;
        Name = name;
        Locatie = locatie;
        Weersinformatie = weersinformatie;
    }

    public Incident()
    {
        
    }

    public long Id { get; set; }
    public Locatie Locatie { get; set; }
    
    public Weersinformatie Weersinformatie { get; set; }
    public string? Name { get; set; }
}