using gb_api.Server.Domain;

namespace gb_api.Server.Data.WeerDB;

public interface IWeerRepository
{
    IEnumerable<Weersinformatie> getWeersinformaties();
    Weersinformatie? getWeersinformatie(long weersinformatieId);

    void Insert(Weersinformatie weersinformatie);
    void Save(){}
    void Update(Weersinformatie weersinformatie);
}