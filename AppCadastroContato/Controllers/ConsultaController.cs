using Microsoft.AspNetCore.Mvc;

namespace AppCadastroContato.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
