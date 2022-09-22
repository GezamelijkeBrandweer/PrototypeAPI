namespace gb_api.Incident.Data
{
    public interface IIncidentRepository
    {
        IEnumerable<Domain.Incident> GetIncidents();
        Domain.Incident? GetIncident(long incidentId);

        void Insert(Domain.Incident incident);
        void Save();
        void UpdateIncident(Domain.Incident incident);
        void DeleteIncident(long incidentId);
    }
}
