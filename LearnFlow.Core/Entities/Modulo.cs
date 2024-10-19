namespace LearnFlow.Core.Entities
{
    public class Modulo : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Aula> Aulas { get; set; }
    }
}
