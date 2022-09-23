using gb_api.Server.Domain;
using Microsoft.EntityFrameworkCore;

namespace gb_api.Server.Data.IncidentDB;

// https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?redirectedfrom=MSDN&view=entity-framework-6.2.0
public sealed class IncidentContext : DbContext
{
    public DbSet<Incident> Incidents { get; set; }
    
    public IncidentContext(DbContextOptions<IncidentContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("gb_backend");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Incident>().Navigation(i => i.Locatie).AutoInclude();
        modelBuilder.Entity<Incident>().Navigation(i => i.Weersinformatie).AutoInclude();
    }
} 