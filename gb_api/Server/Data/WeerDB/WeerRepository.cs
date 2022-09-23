using gb_api.Server.Domain;

namespace gb_api.Server.Data.WeerDB;

public class WeerRepository : IWeerRepository
{
    private readonly WeerContext _context;

    public WeerRepository(WeerContext context)
    {
        _context = context;
    }

    public IEnumerable<Weersinformatie> getWeersinformaties()
    {
        return _context.Weersinformaties;
    }

    public Weersinformatie? getWeersinformatie(long weersinformatieId)
    {
        return _context.Weersinformaties.Find(weersinformatieId);
    }

    public void Insert(Weersinformatie weersinformatie)
    {
        _context.Add(weersinformatie);
    }

    public void Update(Weersinformatie weersinformatie)
    {
        _context.Update(weersinformatie);
    }
}