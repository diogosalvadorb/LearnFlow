namespace LearnFlow.Core.Entities
{
    public class Curso
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
    }
}
