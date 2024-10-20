using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class UsuarioAssinaturaRepository : IUsuarioAulaConcluidaRepository
    {
        public Task<List<UsuarioAulaConcluida>> GetGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioAulaConcluida> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(UsuarioAulaConcluida usuarioAulaConcluida)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
