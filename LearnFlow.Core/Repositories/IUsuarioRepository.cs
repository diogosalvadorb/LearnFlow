using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetGetAllAsync();
        Task<Usuario> GetByIdAsync(Guid id);
        Task AddAsync(Usuario usuario);
        Task SaveChangesAsync();
    }
}
