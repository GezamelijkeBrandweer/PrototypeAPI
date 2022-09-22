namespace gb_api.Incident.Data
{
    public sealed class IncidentRepository : IIncidentRepository
    {
        private readonly IncidentContext _context;

        public IncidentRepository(IncidentContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Domain.Incident> GetIncidents()
        {
            return _context.Incidents;
        }
        
        public Domain.Incident? GetIncident(long incidentId)
        {
            return _context.Incidents.Find(incidentId);
        }

        public void Insert(Domain.Incident incident)
        {
            _context.Add(incident);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateIncident(Domain.Incident incident)
        {
            _context.Update(incident);
        }

        public void DeleteIncident(long incidentId)
        {
            _context.Remove(incidentId);
        }
    }
}
