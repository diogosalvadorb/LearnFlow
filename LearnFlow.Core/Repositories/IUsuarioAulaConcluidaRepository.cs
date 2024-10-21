using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IUsuarioAulaConcluidaRepository
    {
        Task<List<UsuarioAulaConcluida>> GetGetAllAsync();
        Task<UsuarioAulaConcluida> GetByIdAsync(Guid id);
        Task AddAsync(UsuarioAulaConcluida usuarioAulaConcluida);
        Task SaveChangesAsync();
    }
}
