using gb_api.Server.Domain;

namespace gb_api.Server.Data.IncidentDB;

public interface IIncidentRepository
{
    IEnumerable<Incident> GetIncidents();
    Incident? GetIncident(long incidentId);

    void Insert(Incident incident);
    void Save();
    void UpdateIncident(Incident incident);
    void DeleteIncident(long incidentId);
}