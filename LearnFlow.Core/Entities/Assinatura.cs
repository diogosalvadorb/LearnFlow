namespace LearnFlow.Core.Entities
{
    public class Assinatura : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public int Duracao { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
