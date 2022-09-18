namespace Loja.Web.Models
{
    [Table("Compras")]
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produtos { get; set; }
    }
}
