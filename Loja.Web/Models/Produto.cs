namespace Loja.Web.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [MaxLength(100, ErrorMessage = "Tamanho máximo é 100.")]
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [MaxLength(400, ErrorMessage = "Tamanho máximo é 400.")]
        [Required]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        [MaxLength(100, ErrorMessage = "Tamanho máximo é 100.")]
        [Required]
        [Display(Name = "UrlImg")]
        public string UrlImg { get; set; }
        [Display(Name = "Preco")]
        public double Preco { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public List<Compra> Compras { get; set; }
    }
}
