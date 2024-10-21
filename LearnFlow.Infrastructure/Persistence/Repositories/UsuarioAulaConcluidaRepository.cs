using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class UsuarioAulaConcluidaRepository : IUsuarioAulaConcluidaRepository
    {
        private readonly DataBaseContext _dbContext;
        public UsuarioAulaConcluidaRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UsuarioAulaConcluida>> GetGetAllAsync()
        {
            return await _dbContext.UsuarioAulaConcluidas.ToListAsync();
        }

        public async Task<UsuarioAulaConcluida> GetByIdAsync(Guid id)
        {
            return await _dbContext.UsuarioAulaConcluidas.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(UsuarioAulaConcluida usuarioAulaConcluida)
        {
            await _dbContext.AddAsync(usuarioAulaConcluida);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
