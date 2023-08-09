using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Controllers
{
    public class Aluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
