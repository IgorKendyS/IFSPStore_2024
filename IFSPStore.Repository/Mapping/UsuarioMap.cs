using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace IFSPStore.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .HasConversion(x => x!.ToString(), x => x)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Login)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.DataCadastro)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DataLogin)
                .IsRequired();

            builder.Property(x => x.Ativo);
        }
    }
}
