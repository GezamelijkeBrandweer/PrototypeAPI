using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using IncidentPackage.Domain;
using Microsoft.Extensions.Options;

namespace IncidentPackage.Data
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?redirectedfrom=MSDN&view=entity-framework-6.2.0
    public class IncidentContext : DbContext 
    {
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("gb_backend");
        }
    }
}
