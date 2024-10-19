using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class AssinaturaConfiguration : IEntityTypeConfiguration<Assinatura>
    {
        public void Configure(EntityTypeBuilder<Assinatura> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(x => x.Cursos)
                .WithOne(x => x.Assinatura)
                .HasForeignKey(x => x.AssinaturaId).
                OnDelete(DeleteBehavior.Cascade);
        }
    }
}
