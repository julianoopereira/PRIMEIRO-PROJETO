using Microsoft.AspNetCore.Mvc;
using PRIMEIRO_PROJETO.Data.Repositorio.Interfaces;
using PRIMEIRO_PROJETO.Models;
using System.Text.Json;


namespace PRIMEIRO_PROJETO.Controllers
{
    public class AlunoController : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IConfiguration configuration, IAlunoRepositorio alunoRepositorio)
        {
            _configuration = configuration;
            _alunoRepositorio = alunoRepositorio;
        }

        public IActionResult Aluno()
        {
            ///lista de alunos
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }

        public async Task<IActionResult> BuscarEndereco(string cep)
        {
            Endereco endereco = new Endereco();
            try
            {
                cep = cep.Replace("-", "");

                using var client = new HttpClient();
                var result = await client.GetAsync(_configuration.GetSection("ApiCep")["BaseUrl"] + cep + "/jason");


                if (result.IsSuccessStatusCode)
                {
                    endereco = JsonSerializer.Deserialize<Endereco>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions() { });
                }

                else
                {
                    ViewData["MsgErro"] = "Erro na busca de endereço!";
                }

            }
            catch (Exception e)
            {

                throw;
            }
            ViewData["MsgAcept"] = "Sucesso na Busca do Endereço !";

            return View("Endereco", endereco);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch (Exception e)
            {
                TempData["MsgErro"] = "Erro ao inserir Aluno";
            }
            TempData["MsgErro"] = "Aluno adicionado com sucesso!!";

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            Aluno aluno = _alunoRepositorio.BuscarId(Id);
            return View(aluno);
        }
        public IActionResult EditarAluno(Aluno aluno)
        {
            _alunoRepositorio.EditarAluno(aluno);
            return RedirectToAction("Index");
        }

        //public IActionResult ExcluirAluno(Aluno aluno);
        //{
        //   _alunoRepositorio.ExcluirAluno(aluno);
        //    retur RedirectToAction("Index");
        // }

        public IActionResult ExcluirConfirmacao(int Id)
        {
        Aluno aluno = _alunoRepositorio.BuscarId(Id);
        return View(aluno);
        }
        public IActionResult Apagar(int Id)
        {
        _alunoRepositorio.Apagar(Id);
        return RedirectToAction("Aluno");
        }

        public IActionResult AlterarAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.AtualizarAluno(aluno);
            }
            catch (Exception e)
            {
                TempData["MsgErro"] = "Erro ao inserir Aluno";
            }
            
            return RedirectToAction("Aluno");

        }
    }
}

  
