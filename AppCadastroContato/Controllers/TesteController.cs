using Microsoft.AspNetCore.Mvc;

namespace AppCadastroContato.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
