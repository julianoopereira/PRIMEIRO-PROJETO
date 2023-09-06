using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Models
{
    public class Aluno 
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Matricula { get; set; }

        public string DataNascimento { get; set; }

        public string Endereco { get; set; }

        //public string Email { get; set; }

        public string Cep { get; set; }

        public string Curso { get; set; }
        

        //public string Senha { get; set; }
    }
}

