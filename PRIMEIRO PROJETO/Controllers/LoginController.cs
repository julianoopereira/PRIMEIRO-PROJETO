using Microsoft.AspNetCore.Mvc;
using PRIMEIRO_PROJETO.Data.Repositorio.Interfaces;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Controllers
{
    public class LogginController : Controller
    {

        private readonly ILoginRepositorio _loginRepositorio;
        public LogginController(ILoginRepositorio loginRepositorio)
        {
                    _loginRepositorio = loginRepositorio;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult BuscaLogin(Login login)
        {
            try
            {
                var acesso = _loginRepositorio.ValidarUsuario(login);


                if (acesso != null)
                {
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    TempData["MsgErro"] = "Usuário ou enhra incorretos! Tente Novamente";
                }
                return View("Index");

            }
            catch (Exception)
            {
                throw;

                TempData["MsgErro"] = "Erro ao buscar Usuário";
            }
            return View("Index");
                                
        }
    }
}
