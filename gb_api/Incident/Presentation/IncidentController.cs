using gb_api.Incident.Application;
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
        public Domain.Incident? Create(long id, string? name)
        {
            _service.Add(new Domain.Incident(id, name));
            return Get(id);
        }

        [HttpGet]
        public Domain.Incident? Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut]
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
    }
}
