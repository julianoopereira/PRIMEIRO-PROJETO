using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View("Cadastro");
        }
    }
}
