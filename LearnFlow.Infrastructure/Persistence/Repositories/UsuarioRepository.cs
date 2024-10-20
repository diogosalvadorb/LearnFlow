using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<List<Usuario>> GetGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
