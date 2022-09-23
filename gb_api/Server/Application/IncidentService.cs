using gb_api.Server.Data.IncidentDB;
using gb_api.Server.Domain;

namespace gb_api.Server.Application;

public sealed class IncidentService
{
    private readonly WeerService _weerService;
    private readonly LocatieService _locatieService;
    private readonly IIncidentRepository _repository;

    public IncidentService(IIncidentRepository repository, LocatieService locatieService, WeerService weerService)
    {
        _repository = repository;
        _locatieService = locatieService;
        _weerService = weerService;
    }

    public async Task<Incident> Add(long id, string? name, string postcode, int huisnummer)
    {
        var locatie = await _locatieService.GetLocatieFromPostcodeHuisnummer(postcode, huisnummer);

        // convert de lat en long naar goede format
        // var weer = await _weerService.GetWeerFromLocatie(locatie.Latitude,locatie.Longitude);
        var weer = await _weerService.GetWeerFromLocatie(12,12);
        
        var incident = new Incident(id, name, locatie, weer);
        _repository.Insert(incident);
        return incident;
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