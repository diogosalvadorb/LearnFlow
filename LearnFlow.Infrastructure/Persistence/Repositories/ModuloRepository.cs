using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class ModuloRepository : IModuloRepository
    {
        public Task<List<Modulo>> GetGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Modulo> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Modulo modulo)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
