using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IPagamentoAssinaturaRepository
    {
        Task<List<PagamentoAssinatura>> GetGetAllAsync();
        Task<PagamentoAssinatura> GetByIdAsync(Guid id);
        Task AddAsync(PagamentoAssinatura pagamentoAssinatura);
        Task SaveChangesAsync();
    }
}
