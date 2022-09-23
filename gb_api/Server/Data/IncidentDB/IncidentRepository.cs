using gb_api.Server.Domain;

namespace gb_api.Server.Data.IncidentDB;

public sealed class IncidentRepository : IIncidentRepository
{
    private readonly IncidentContext _context;

    public IncidentRepository(IncidentContext context)
    {
        _context = context;
    }

    public IEnumerable<Incident> GetIncidents()
    {
        return _context.Incidents;
    }

    public Incident? GetIncident(long incidentId)
    {
        return _context.Incidents.Find(incidentId);
    }

    public void Insert(Incident incident)
    {
        _context.Add(incident);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void UpdateIncident(Incident incident)
    {
        _context.Update(incident);
    }

    public void DeleteIncident(long incidentId)
    {
        _context.Remove(incidentId);
    }
}