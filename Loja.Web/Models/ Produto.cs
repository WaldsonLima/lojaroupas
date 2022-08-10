namespace Loja.Web.Models
{
    public class  Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public List<Compra> Compras { get; set; }
    }
}
