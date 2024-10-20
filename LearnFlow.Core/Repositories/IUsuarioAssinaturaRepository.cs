using LearnFlow.Core.Entities;

namespace LearnFlow.Core.Repositories
{
    internal interface IUsuarioAssinaturaRepository
    {
        Task<List<UsuarioAssinatura>> GetGetAllAsync();
        Task<UsuarioAssinatura> GetByIdAsync(Guid id);
        Task AddAsync(UsuarioAssinatura usuarioAssinatura);
        Task SaveChangesAsync();
    }
}
