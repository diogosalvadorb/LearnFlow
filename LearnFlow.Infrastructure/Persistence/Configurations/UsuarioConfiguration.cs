using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Ignore(x => x.UsuarioAssinaturas);

            builder
                .HasMany(x => x.UsuarioAssinaturas)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.UsuarioAulaConcluidas)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
