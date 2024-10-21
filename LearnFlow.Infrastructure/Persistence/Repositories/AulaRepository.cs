using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class AulaRepository : IAulaRepository
    {
        private readonly DataBaseContext _dbContext;
        public AulaRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Aula>> GetAllAsync()
        {
            return await _dbContext.Aulas.ToListAsync();
        }

        public async Task<Aula> GetByIdAsync(Guid id)
        {
            return await _dbContext.Aulas.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Aula aula)
        {
            await _dbContext.Aulas.AddAsync(aula);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
