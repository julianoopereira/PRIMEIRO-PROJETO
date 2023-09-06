using PRIMEIRO_PROJETO.Data.Repositorio.Interfaces;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;


        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }

        public void InserirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public Aluno AtualizarAluno(Aluno aluno)
        {
            Aluno alunoDb = BuscarId(aluno.Id);

            if (alunoDb == null)
            {
                throw new System.Exception("Houve um erro na atualização do Aluno !");
            }
            alunoDb.Nome = aluno.Nome;
            alunoDb.Matricula = aluno.Matricula;
            alunoDb.Curso = aluno.Curso;
            alunoDb.Cep = aluno.Cep;
            alunoDb.Endereco = aluno.Endereco;
            alunoDb.DataNascimento = aluno.DataNascimento;

            _bancoContexto.Aluno.Update(alunoDb);
            _bancoContexto.SaveChanges();

            return alunoDb;
        }

        public bool Apagar(int Id)
        {
            Aluno alunoDb = BuscarId(Id);

            if (alunoDb == null)
            {
                throw new System.Exception("Erro em Deletar esse Aluno !");
            }
            _bancoContexto.Aluno.Remove(alunoDb);
            _bancoContexto.SaveChanges();

            return true;
        }

        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
    }
}
