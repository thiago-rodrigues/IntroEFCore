using Efcore.Data.Configuration;
using Efcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Efcore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Data source=TRR-Note;Initial Catalog=EFCore;Integrated Security=false;User Id=sa, Password=masterkey");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}