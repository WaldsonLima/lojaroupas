namespace Loja.Web.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [MaxLength(100, ErrorMessage = "Tamanho máximo é 100.")]
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [MaxLength(200, ErrorMessage = "Tamanho máximo é 200.")]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [MaxLength(50, ErrorMessage = "Tamanho máximo é 50.")]
        [Required]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
