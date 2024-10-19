using LearnFlow.Core.Enum;

namespace LearnFlow.Core.Entities
{
    public class PagamentoAssinatura : BaseEntity
    {
        public DateTime DataProcessamento { get; set; }
        public EStatusPagamento StatusPagamento { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public Guid UsuarioAssinaturaId { get; set; }
        public UsuarioAssinatura UsuarioAssinatura { get; set; }
        public string LinkPagamento { get; set; } = string.Empty;
        public string ExternoPagamentoId { get; set; } = string.Empty;
        public DateTime DataVencimento { get; set; }
    }
}
