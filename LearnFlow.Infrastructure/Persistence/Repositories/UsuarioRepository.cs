using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataBaseContext _dbContext;
        public UsuarioRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Usuario>> GetGetAllAsync()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetByIdAsync(Guid id)
        {
            return await _dbContext.Usuarios.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Usuario usuario)
        {
            await _dbContext.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
