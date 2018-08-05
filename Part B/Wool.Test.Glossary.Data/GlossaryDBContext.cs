using Microsoft.EntityFrameworkCore;
using Wool.Test.Glossary.Data.Entities;

namespace Wool.Test.Glossary.Data
{
    public class GlossaryDBContext : DbContext
    {
        public GlossaryDBContext(DbContextOptions<GlossaryDBContext> options) : base(options)
        {

        }
        public DbSet<GlossaryTerm> GlossaryTerms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GlossaryTerm>().ToTable("GlossaryTerm");
        }
    }
}

