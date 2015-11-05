using Daterbase.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Daterbase.Data
{
    public class TheDaterbase : DbContext
    {
        public TheDaterbase() : base("TheDaterbase")
        {
        }


        public DbSet<DaterProfile> DaterProfiles { get; set; }
        public DbSet<Match> Matchs { get; set; }


    }
}
