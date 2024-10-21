using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class ModuloRepository : IModuloRepository
    {
        private readonly DataBaseContext _dbContext;
        public ModuloRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Modulo>> GetGetAllAsync()
        {
            return await _dbContext.Modulos.ToListAsync();
        }

        public async Task<Modulo> GetByIdAsync(Guid id)
        {
            return await _dbContext.Modulos.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Modulo modulo)
        {
            await _dbContext.AddAsync(modulo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
