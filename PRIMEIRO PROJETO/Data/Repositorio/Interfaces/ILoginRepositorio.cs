using Microsoft.AspNetCore.Mvc;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data.Repositorio.Interfaces
{
    public interface ILoginRepositorio
    {

        public Login ValidarUsuario(Login login);
        
            //throw new NotImplementedException();
        
    }
}