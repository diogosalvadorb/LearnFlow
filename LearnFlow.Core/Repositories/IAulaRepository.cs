using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IAulaRepository
    {
        Task<List<Aula>> GetAllAsync();
        Task<Aula> GetByIdAsync(Guid id);
        Task AddAsync(Aula aula);
        Task SaveChangesAsync();
    }
}
