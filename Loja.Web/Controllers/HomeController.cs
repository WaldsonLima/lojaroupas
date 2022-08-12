using Loja.Web.ViewModels;

namespace Loja.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICategoriaRepository _categoriaRepository;

    public HomeController(ILogger<HomeController> logger, IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
    {
        _logger = logger;
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
