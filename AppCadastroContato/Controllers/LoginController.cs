using AppCadastroContato.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCadastroContato.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrar(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(loginModel.Login == "ze" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = $"Senha do usuário é inválida, tente novamente!";
                }

                return View("Index");  

            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        
        }
    }
}
