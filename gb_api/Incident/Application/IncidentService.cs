using gb_api.Incident.Data;

namespace gb_api.Incident.Application
{
    public sealed class IncidentService
    {
        private readonly IIncidentRepository _repository;
        public IncidentService(IIncidentRepository repository)
        {
            _repository = repository;
        }

        public void Add(Domain.Incident incident)
        {
            _repository.Insert(incident);
        }

        public Domain.Incident? Get(long id)
        {
            return _repository.GetIncident(id);
            //return Incidents.FirstOrDefault(ic => ic.Id == id);
        }

        public void Update()
        {
            //return _repository.UpdateIncident();
            throw new NotImplementedException();
        }
    }
}
