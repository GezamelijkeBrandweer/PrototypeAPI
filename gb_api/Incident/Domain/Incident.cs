namespace gb_api.Incident.Domain
{
    public class Incident
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        public Incident(long id, string? name)
        {
            Id = id;
            Name = name;
        }
    }
}