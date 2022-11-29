using Microsoft.EntityFrameworkCore;
using RestAPI_Primeiro_Exemplo.DataModels;

namespace RestAPI_Primeiro_Exemplo
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=AtosEntity3;User ID=AtosEntity3;password=AtosEntity3;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
