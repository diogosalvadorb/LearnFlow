using LearnFlow.Core.Enum;

namespace LearnFlow.Core.Entities
{
    public class UsuarioAssinatura : BaseEntity
    {
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Guid AssinaturaId { get; set; }
        public Assinatura Assinatura { get; set; }
        public Guid PagamentoAssinaturaId { get; set; }
        public PagamentoAssinatura PagamentoAssinatura { get; set; }
        public EStatusAssinatura StatusAssinatura { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
