using Efcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Efcore.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {            
            builder.ToTable("Clientes");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(c => c.Telefone).HasColumnType("CHAR(11)");
            builder.Property(c => c.CEP).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(c => c.Estado).HasColumnType("CHAR(2)").IsRequired();
            builder.Property(c => c.Cidade).HasColumnType("VARCHAR(60)").HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone");           
        }
    }
}