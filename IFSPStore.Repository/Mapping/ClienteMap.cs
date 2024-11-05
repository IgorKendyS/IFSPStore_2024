using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Documento)
                .IsRequired();
            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.HasOne(x => x.Cidade);
        }
    }
}
