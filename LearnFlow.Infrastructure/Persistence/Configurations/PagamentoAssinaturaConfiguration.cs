using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnFlow.Infrastructure.Persistence.Configurations
{
    public class PagamentoAssinaturaConfiguration : IEntityTypeConfiguration<PagamentoAssinatura>
    {
        public void Configure(EntityTypeBuilder<PagamentoAssinatura> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.UsuarioAssinatura)
                .WithOne(x => x.PagamentoAssinatura)
                .HasForeignKey<PagamentoAssinatura>(x => x.UsuarioAssinaturaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
