using LearnFlow.Core.Repositories;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class PagamentoAssinatura : IPagamentoAssinatura
    {
        public Task<List<Core.Entities.PagamentoAssinatura>> GetGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.PagamentoAssinatura> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Core.Entities.PagamentoAssinatura pagamentoAssinatura)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
