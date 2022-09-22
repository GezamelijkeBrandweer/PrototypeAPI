using IncidentPackage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentPackage.Data
{
    public interface IIncidentRepository
    {
        IEnumerable<Incident> GetIncidents();
        Incident? GetIncident(long incidentId);

        void Insert(Incident incident);
        void Save();
        void UpdateIncident(Incident incident);
        void DeleteIncident(long incidentId);
    }
}
