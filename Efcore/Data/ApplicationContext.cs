using Efcore.Data.Configuration;
using Efcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Efcore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Data Source=TRR-NOTE;User Id=sa;Password=masterkey;Initial Catalog=EFCore;Integrated Security=false;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}