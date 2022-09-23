using gb_api.Incident.Application;
using MapsAPILib;
using Microsoft.AspNetCore.Mvc;

namespace gb_api.Incident.Presentation
{
    [ApiController]
    [Route("/incident")]
    public class IncidentController : ControllerBase
    {
        private readonly IncidentService _service;

        public IncidentController(IncidentService service)
        {
            _service = service;
        }
        
        [HttpPost]
        public void Create(Domain.Incident incident)
        {
            _service.Add(incident);
        }

        [HttpGet("{id}")]
        public Domain.Incident? Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public Domain.Incident? Update(long id, Domain.Incident incident)
        {
            if(id != incident.Id)
            {
                return null;
            }
            
            var existingIncident = _service.Get(id);
            if(existingIncident is null)
            {
                return null;
            }
            
            _service.Update();
            return existingIncident;
        }

        [HttpGet("/request")]
        public async Task<List<TrafficIncident>?> TestRequest()
        {
            MapsApi api = new(null);
            List<TrafficIncident> incidents = await api.GetIncidentsIn(Array.Empty<double>());
            return incidents;
        }
    }
}
