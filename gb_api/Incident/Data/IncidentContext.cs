using Microsoft.EntityFrameworkCore;

namespace gb_api.Incident.Data
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?redirectedfrom=MSDN&view=entity-framework-6.2.0
    public class IncidentContext : DbContext 
    {
        public DbSet<Domain.Incident> Incidents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("gb_backend");
        }
    }
}
