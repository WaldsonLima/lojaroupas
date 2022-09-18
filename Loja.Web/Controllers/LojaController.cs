namespace Loja.Web.Controllers
{
	public class LojaController : Controller
	{
		private readonly IProdutoRepository _produtoRepository;
		private readonly ICategoriaRepository _categoriaRepository;

		public LojaController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
		{
			_produtoRepository = produtoRepository;
			_categoriaRepository = categoriaRepository;
		}
		
		public IActionResult Index() 
		{
			// var produtos = _produtoRepository.Produtos;
			// return View(produtos);

			var produtoViewModel = new ProdutoViewModel();
			produtoViewModel.Produtos = _produtoRepository.Produtos;
			produtoViewModel.CategoriaAtual = "Categoria Atual";

			return View(produtoViewModel);
		}
	}
}
