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
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.Senha)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.Login)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.DataCadastro)
                .HasDefaultValue(new DateTime());
            builder.Property(x => x.DataLogin);
            builder.Property(x => x.Ativo);
        }
    }
}
