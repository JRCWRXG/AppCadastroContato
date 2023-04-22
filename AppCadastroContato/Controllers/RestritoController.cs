using AppCadastroContato.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AppCadastroContato.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
