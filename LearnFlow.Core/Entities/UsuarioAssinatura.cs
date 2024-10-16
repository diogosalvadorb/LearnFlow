using LearnFlow.Core.Enum;

namespace LearnFlow.Core.Entities
{
    public class UsuarioAssinatura
    {
        public Guid IdUsuario { get; set; }
        public Guid IdAssinatura { get; set; }
        public StatusAssinatura StatusAssinatura { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
