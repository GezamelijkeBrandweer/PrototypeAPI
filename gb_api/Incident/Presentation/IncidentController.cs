using IncidentPackage.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb_api.Incident.Domain;

namespace IncidentPackage.Presentation
{
    [ApiController]
    [Route("/incident")]
    public class IncidentController : ControllerBase
    {
        [HttpPost]
        public void Create(Incident incident)
        {
            IncidentService.Add(incident);
        }

        [HttpGet("{id}")]
        public Incident? Get(long id)
        {
            return IncidentService.Get(id);
        }

        [HttpPut("{id}")]
        public Incident? Update(long id, Incident incident)
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
