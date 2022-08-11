namespace Loja.Web.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage = "Tamanho máximo é 100.")]
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
