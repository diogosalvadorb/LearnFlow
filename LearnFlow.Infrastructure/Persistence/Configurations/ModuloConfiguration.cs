using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class ModuloConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Aulas)
                .WithOne(x => x.Modulo)
                .HasForeignKey(x => x.ModuloId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
