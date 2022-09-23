using gb_api.Server.Application;
using gb_api.Server.Domain;
using Microsoft.AspNetCore.Mvc;

namespace gb_api.Server.Presentation;

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
    public Incident? Create(long id, string? name, string postcode, int huisnummer)
    {
        _service.Add(id, name, postcode, huisnummer);
        return Get(id);
    }

    [HttpGet]
    public Incident? Get(long id)
    {
        return _service.Get(id);
    }

    [HttpPut]
    public Incident? Update(long id, Incident incident)
    {
        if (id != incident.Id) return null;

        var existingIncident = _service.Get(id);
        if (existingIncident is null) return null;

        _service.Update();
        return existingIncident;
    }
}