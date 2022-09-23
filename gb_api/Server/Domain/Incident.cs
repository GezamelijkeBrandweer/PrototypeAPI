namespace gb_api.Server.Domain;

public class Incident
{
    public Incident(long id, string? name, Locatie locatie)
    {
        Id = id;
        Name = name;
        Locatie = locatie;
    }

    public Incident()
    {
        
    }

    public long Id { get; set; }
    public Locatie Locatie { get; set; }
    public string? Name { get; set; }
}