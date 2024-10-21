using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IModuloRepository
    {
        Task<List<Modulo>> GetGetAllAsync();
        Task<Modulo> GetByIdAsync(Guid id);
        Task AddAsync(Modulo modulo);
        Task SaveChangesAsync();
    }
}
