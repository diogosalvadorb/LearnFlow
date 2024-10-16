namespace LearnFlow.Core.Entities
{
    public class Assinatura
    {
        public string Nome { get; set; } = string.Empty;
        public int Duracao { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
