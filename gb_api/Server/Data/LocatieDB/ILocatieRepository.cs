using gb_api.Server.Domain;

namespace gb_api.Server.Data.LocatieDB;

public interface ILocatieRepository
{
    IEnumerable<Locatie> getLocaties();
    Locatie? getLocatie(long locatieId);

    void Insert(Locatie locatie);
    void Save(){}
    void Update(Locatie locatie);
    

}