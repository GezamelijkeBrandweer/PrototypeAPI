using gb_api.Server.Data;
using gb_api.Server.Data.IncidentDB;
using gb_api.Server.Domain;

namespace gb_api.Server.Application;

public sealed class IncidentService
{
    private readonly LocatieService _locatieService;
    private readonly IIncidentRepository _repository;

    public IncidentService(IIncidentRepository repository, LocatieService locatieService)
    {
        _repository = repository;
        _locatieService = locatieService;
    }

    public async void Add(long id, string? name, string postcode, int huisnummer)
    {
        var locatie = await _locatieService.GetLocatieFromPostcodeHuisnummer(postcode, huisnummer);
        Console.WriteLine(locatie);
        var incident = new Incident(id, name, locatie);
        _repository.Insert(incident);
    }

    public Incident? Get(long id)
    {
        return _repository.GetIncident(id);
    }

    public void Update()
    {
        //return _repository.UpdateIncident();
        throw new NotImplementedException();
    }
}