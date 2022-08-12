namespace Loja.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
