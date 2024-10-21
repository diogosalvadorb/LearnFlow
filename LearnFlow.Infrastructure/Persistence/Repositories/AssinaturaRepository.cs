using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
        private readonly DataBaseContext _dbContext;
        public AssinaturaRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Assinatura>> GetGetAllAsync()
        {
            return await _dbContext.Assinaturas.ToListAsync();
        }

        public async Task<Assinatura> GetByIdAsync(Guid id)
        {
            return await _dbContext.Assinaturas.SingleOrDefaultAsync(x => x.Id ==id);
        }

        public async Task AddAsync(Assinatura assinatura)
        {
            await _dbContext.AddAsync(assinatura);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
