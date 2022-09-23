using gb_api.Server.Domain;

namespace gb_api.Server.Data.LocatieDB;

public class LocatieRepository : ILocatieRepository
{
    private readonly LocatieContext _context;

    public LocatieRepository(LocatieContext context)
    {
        _context = context;
    }

    public IEnumerable<Locatie> getLocaties()
    {
        return _context.Locaties;
    }

    public Locatie? getLocatie(long locatieId)
    {
        return _context.Locaties.Find(locatieId);
    }

    public void Insert(Locatie locatie)
    {
        _context.Add(locatie);
    }

    public void Update(Locatie locatie)
    {
        _context.Update(locatie);
    }
}