using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb_api.Incident.Domain;

namespace IncidentPackage.Application
{
    public static class IncidentService
    {
        static List<Incident> Incidents { get; }
        static IncidentService()
        {
            Incidents = new List<Incident>
            {
                new Incident(2L),
                new Incident(3L)
            };
        }

        public static void Add(Incident incident)
        {
            Incidents.Add(incident);  
        }

        public static Incident? Get(long id)
        {
            return Incidents.FirstOrDefault(ic => ic.Id == id);
        }

        public static void Update()
        {
            throw new NotImplementedException();
        }
    }
}
