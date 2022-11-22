using AtosEntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AtosEntityCodeFirst
{
    class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=AtosEntity1; User ID=AtosEntity1; Password=AtosEntity1; Language=Portuguese; Trusted_Connection=True; TrustServerCertificate=True;");            
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e =>e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
