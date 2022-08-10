namespace Loja.Web.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
