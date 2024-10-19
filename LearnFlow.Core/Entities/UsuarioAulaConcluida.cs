namespace LearnFlow.Core.Entities
{
    public class UsuarioAulaConcluida : BaseEntity
    {
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Guid AulaId { get; set; }
        public Aula Aula { get; set; }
        public DateTime DataConclusao { get; set; }
        public int Nota { get; set; }
    }
}
