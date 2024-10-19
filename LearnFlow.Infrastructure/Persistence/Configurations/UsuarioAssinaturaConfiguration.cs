using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class UsuarioAssinaturaConfiguration : IEntityTypeConfiguration<UsuarioAssinatura>
    {
        public void Configure(EntityTypeBuilder<UsuarioAssinatura> builder)
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}
