using Microsoft.AspNetCore.Mvc;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio 
    {
        List<Aluno> BuscarAlunos();

        void InserirAluno(Aluno aluno);

        Aluno BuscarId(int id);

        void EditarAluno(Aluno aluno);

        void ExcluirAluno(Aluno aluno);

        Aluno AtualizarAluno(Aluno aluno);

        bool Apagar(int Id);
                
    }
}
