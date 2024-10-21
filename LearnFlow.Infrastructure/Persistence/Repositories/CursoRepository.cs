using LearnFlow.Core.Entities;
using LearnFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnFlow.Infrastructure.Persistence.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly DataBaseContext _dbContext;
        public CursoRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Curso>> GetAllAsync()
        {
            return await _dbContext.Cursos.ToListAsync();
        }

        public async Task<Curso> GetByIdAsync(Guid id)
        {
            return await _dbContext.Cursos.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Curso curso)
        {
            await _dbContext.Cursos.AddAsync(curso);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
