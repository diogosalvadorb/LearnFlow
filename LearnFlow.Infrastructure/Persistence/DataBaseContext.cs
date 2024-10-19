using LearnFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LearnFlow.Infrastructure.Persistence
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Assinatura> Assinaturas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<PagamentoAssinatura> PagamentoAssinaturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAssinatura> UsuarioAssinaturas { get; set; }
        public DbSet<UsuarioAulaConcluida> usuarioAulaConcluidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
