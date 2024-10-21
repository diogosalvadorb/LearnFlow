using LearnFlow.Core.Repositories;
using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class PagamentoAssinaturaRepository : IPagamentoAssinaturaRepository
    {
        private readonly DataBaseContext _dbContext;
        public PagamentoAssinaturaRepository(DataBaseContext dvContext)
        {
            _dbContext = dvContext;
        }

        public async Task<List<PagamentoAssinatura>> GetGetAllAsync()
        {
            return await _dbContext.PagamentoAssinaturas.ToListAsync();
        }

        public async Task<PagamentoAssinatura> GetByIdAsync(Guid id)
        {
            return await _dbContext.PagamentoAssinaturas.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(PagamentoAssinatura pagamentoAssinatura)
        {
            await _dbContext.AddAsync(pagamentoAssinatura);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
