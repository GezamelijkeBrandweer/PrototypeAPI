using gb_api.Server.Domain;
using Microsoft.EntityFrameworkCore;

namespace gb_api.Server.Data.WeerDB;

public sealed class WeerContext : DbContext
{
    public DbSet<Weersinformatie> Weersinformaties { get; set; }
    
    public WeerContext(DbContextOptions<WeerContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("gb_backend");
    }

}