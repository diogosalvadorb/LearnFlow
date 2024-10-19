using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class AulaConfiguration : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(u => u.UsuarioAulaConcluida)
                .WithOne(a => a.Aula)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
