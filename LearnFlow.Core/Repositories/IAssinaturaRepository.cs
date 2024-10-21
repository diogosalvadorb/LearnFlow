using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IAssinaturaRepository
    {
        Task<List<Assinatura>> GetGetAllAsync();
        Task<Assinatura> GetByIdAsync(Guid id);
        Task AddAsync(Assinatura assinatura);
        Task SaveChangesAsync();
    }
}
