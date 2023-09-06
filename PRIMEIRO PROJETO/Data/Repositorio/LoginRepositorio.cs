using PRIMEIRO_PROJETO.Data.Repositorio.Interfaces;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    { 
        private readonly BancoContexto _bancoContexto;

        public LoginRepositorio(BancoContexto bancoContexto)
        {
        _bancoContexto = bancoContexto;
        }

                public Login ValidarUsuario(Login login)
                {
            return _bancoContexto.Login.FirstOrDefault(x => x.Email ==login.Email && x.Senha == login.Senha);
                }
    }

    public interface ILoginRepositorio2
    {
    }
}