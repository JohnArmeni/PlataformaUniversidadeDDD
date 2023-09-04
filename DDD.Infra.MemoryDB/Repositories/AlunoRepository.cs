using DDD.Domain.Universidade.Entities;
using DDD.Infra.MemoryDB.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        public readonly ApiContext _context;

        public AlunoRepository(ApiContext context)
        {
            _context = context;
        }
        
        public List<Aluno> GetAlunos()
        {
            using (var context = new ApiContext())
            {
                var list = _context.Alunos.Include(x => x.Disciplinas).ToList();
                return list;
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

        public void UpdateDisciplinaAluno(Aluno Id, Disciplina DisciplinaId)
        {
            var alunoLista = _context.Alunos.Find(Id);
            var disciplinaLista = _context.Disciplinas.Find(DisciplinaId);

            if (alunoLista is null || disciplinaLista is null)
            {
                throw new InvalidOperationException();

            }
            alunoLista.Disciplinas = disciplinaLista;
            _context.SaveChanges();
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
