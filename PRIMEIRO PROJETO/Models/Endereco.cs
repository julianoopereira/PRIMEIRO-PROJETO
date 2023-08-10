using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Models
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ddd { get; set; }


    }


}
