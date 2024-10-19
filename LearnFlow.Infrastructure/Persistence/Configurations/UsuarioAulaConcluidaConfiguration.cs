using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class UsuarioAulaConcluidaConfiguration : IEntityTypeConfiguration<UsuarioAulaConcluida>
    {
        public void Configure(EntityTypeBuilder<UsuarioAulaConcluida> builder)
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}
