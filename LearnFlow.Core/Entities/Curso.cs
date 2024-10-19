namespace LearnFlow.Core.Entities
{
    public class Curso : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public List<Modulo> Modulos { get; set; }
        public Guid AssinaturaId { get; set; }
        public Assinatura Assinatura { get; set; }
    }
}
