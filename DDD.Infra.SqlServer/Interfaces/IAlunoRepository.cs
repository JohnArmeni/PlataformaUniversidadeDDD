using DDD.Domain.Universidade.SecretariaManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Interfaces
{
    public interface IAlunoRepository
    {
        public List<Aluno> GetAlunos(); //READ
        public Aluno GetAlunoById(int id); //READ
        public void InsertAluno(Aluno aluno); //CREATE
        public void UpdateAluno(Aluno aluno); //UPDATE
        
        public void DeleteAluno(Aluno aluno);
    }
}
