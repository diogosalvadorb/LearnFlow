using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class AulaRepository : IAulaRepository
    {
        public Task<List<Aula>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Aula> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Aula aula)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
