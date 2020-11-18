using Efcore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Efcore.Data.Configuration
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("PedidoItens");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
            builder.Property(p => p.valor).IsRequired();
            builder.Property(p => p.Desconto).IsRequired();
        }
    }
}