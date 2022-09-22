using gb_api.Incident.Application;
using Microsoft.AspNetCore.Mvc;

namespace gb_api.Incident.Presentation
{
    [ApiController]
    [Route("/incident")]
    public class IncidentController : ControllerBase
    {
        [HttpPost]
        public void Create(Domain.Incident incident)
        {
            IncidentService.Add(incident);
        }

        [HttpGet("{id}")]
        public Domain.Incident? Get(long id)
        {
            return IncidentService.Get(id);
        }

        [HttpPut("{id}")]
        public Domain.Incident? Update(long id, Domain.Incident incident)
        {
            if(id != incident.Id)
            {
                return null;
            }

            var existingIncident = IncidentService.Get(id);
            if(existingIncident is null)
            {
                return null;
            }

            IncidentService.Update();
            return existingIncident;
        }
    }
}
