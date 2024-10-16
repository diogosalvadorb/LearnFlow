using LearnFlow.Core.Enum;

namespace LearnFlow.Core.Entities
{
    public class PagamentoAssinatura
    {
        public DateTime DataProcessamento { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public Guid IdUsuarioAssinatura { get; set; }
        public string LinkPagamento { get; set; } = string.Empty;
        public string IdExternoPagamento { get; set; } = string.Empty;
        public DateTime DataVencimento { get; set; }
    }
}
