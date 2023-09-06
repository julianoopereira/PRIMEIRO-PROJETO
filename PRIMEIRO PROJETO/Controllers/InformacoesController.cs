using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Controllers
{
    public class InformacoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
