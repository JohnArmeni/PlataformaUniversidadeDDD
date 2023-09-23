using DDD.Domain.Universidade.SecretariaManagementContext;
using DDD.Infra.SqlServer;
using DDD.Infra.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Repositories
{
    public class AlunoRepositorySqlServer : IAlunoRepository
    {
        public readonly SqlContext _context;

        public AlunoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public List<Aluno> GetAlunos()
        {
            using (var context = new SqlContext())
            {
                //var list = _context.Alunos.Include(x => x.Disciplinas).ToList();
                return; //list;
            }
        }

        public Aluno GetAlunoById(int id)
        {
            return _context.Alunos.Find(id);
        }

        public void InsertAluno(Aluno aluno)
        {
            try
            {
                _context.Alunos.Add(aluno);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateAluno(Aluno aluno)
        {
            try
            {
                _context.Entry(aluno).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteAluno(Aluno aluno)
        {
            try
            {
                _context.Set<Aluno>().Remove(aluno);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

    //    List<Aluno> IAlunoRepository.GetAlunos()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Aluno IAlunoRepository.GetAlunoById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void InsertAluno(Aluno aluno)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UpdateAluno(Aluno aluno)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UpdateDisciplinaAluno(Aluno aluno, Disciplina disciplina)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteAluno(Aluno aluno)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

