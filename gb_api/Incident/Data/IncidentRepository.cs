using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb_api.Incident.Data;
using gb_api.Incident.Domain;

namespace IncidentPackage.Data
{
    public class IncidentRepository : IIncidentRepository
    {
        private readonly IncidentContext _context;

        public IncidentRepository(IncidentContext context)
        {
            this._context = context;
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
}
