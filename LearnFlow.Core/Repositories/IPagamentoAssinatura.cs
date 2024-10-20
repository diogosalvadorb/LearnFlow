using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IPagamentoAssinatura
    {
        Task<List<PagamentoAssinatura>> GetGetAllAsync();
        Task<PagamentoAssinatura> GetByIdAsync(Guid id);
        Task AddAsync(PagamentoAssinatura pagamentoAssinatura);
        Task SaveChangesAsync();
    }
}
