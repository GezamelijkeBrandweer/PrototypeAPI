namespace gb_api.Incident.Application
{
    public static class IncidentService
    {
        static List<Domain.Incident> Incidents { get; }
        static IncidentService()
        {
            Incidents = new List<Domain.Incident>
            {
                new Domain.Incident(2L),
                new Domain.Incident(3L)
            };
        }

        public static void Add(Domain.Incident incident)
        {
            Incidents.Add(incident);  
        }

        public static Domain.Incident? Get(long id)
        {
            return Incidents.FirstOrDefault(ic => ic.Id == id);
        }

        public static void Update()
        {
            throw new NotImplementedException();
        }
    }
}
