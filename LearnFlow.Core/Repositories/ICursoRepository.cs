using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface ICursoRepository
    {
        Task<List<Curso>> GetAllAsync();
        Task<Curso> GetByIdAsync(Guid id);
        Task AddAsync(Curso curso);
        Task SaveChangesAsync();
    }
}
