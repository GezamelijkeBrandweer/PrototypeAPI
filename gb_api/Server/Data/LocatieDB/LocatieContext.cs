using gb_api.Server.Domain;
using Microsoft.EntityFrameworkCore;

namespace gb_api.Server.Data.LocatieDB;

public sealed class LocatieContext : DbContext
{
    public DbSet<Locatie> Locaties { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("gb_backend");
    }

}