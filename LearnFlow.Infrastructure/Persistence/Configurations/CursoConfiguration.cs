using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(m => m.Modulos)
                .WithOne(c => c.Curso)
                .HasForeignKey(c => c.CursoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
