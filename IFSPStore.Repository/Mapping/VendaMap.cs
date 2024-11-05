using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder) {
            builder.ToTable("Venda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data)
                .IsRequired();
            builder.Property(x => x.ValorTotal)
                .IsRequired();
            builder.HasOne(x => x.Cliente);
            builder.HasMany(x => x.Items)
                .WithOne(x => x.Venda)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    
    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder <VendaItem> builder)
        {
            builder.ToTable("VendaItem");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade)
                .IsRequired();
            builder.Property(x => x.ValorTotal)
                .IsRequired();
            builder.Property(x => x.ValorUnitario)
                .IsRequired();

            builder.HasOne(x => x.Produto);

            builder.HasOne(x => x.Venda)
                .WithMany(x => x.Items)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
