using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        public Task<List<Curso>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Curso> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
