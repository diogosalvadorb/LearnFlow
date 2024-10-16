namespace LearnFlow.Core.Entities
{
    public class UsuarioAulaConcluida
    {
        public Guid IdUsuario { get; set; }
        public Guid IdAula { get; set; }
        public DateTime DataConclusao { get; set; }
        public int Nota { get; set; }
    }
}
