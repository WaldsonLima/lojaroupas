namespace Loja.Web.Models
{
    [Table("TipoUsuaris")]
    public class TipoUsuario
    {
        [Key]
        public int TipoUsuarioId { get; set; }
        [MaxLength(100, ErrorMessage = "Tamanho máximo é 100.")]
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
