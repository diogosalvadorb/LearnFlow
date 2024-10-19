namespace LearnFlow.Core.Entities
{
    public class Aula : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string LinkVideo { get; set; } = string.Empty;
        public int Duracao { get; set; }
        public Guid ModuloId { get; set; }
        public Modulo Modulo { get; set; }
        public List<UsuarioAulaConcluida> UsuarioAulaConcluida { get; private set; }
    }
}
