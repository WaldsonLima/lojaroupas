namespace Loja.Web.Models
{
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        public string Nome { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
