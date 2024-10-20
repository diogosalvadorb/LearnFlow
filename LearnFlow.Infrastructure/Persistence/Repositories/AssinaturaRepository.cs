using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
        public Task<List<Assinatura>> GetGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Curso> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Assinatura assinatura)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
