using DDD.Domain.Universidade.SecretariaManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Repositories
{


    public class ProfessorRepositorySqlServer : IProfessorRepository
        {
            private readonly SqlContext _context;

            public ProfessorRepositorySqlServer(SqlContext context)
            {
                _context = context;
            }

            public List<Professor> GetProfessores()
            {
                using (var context = new SqlContext())
                {
                    var list = _context.Professores.ToList();
                    return list;
                }
            }

            public Professor GetProfessorById(int id)
            {
                return _context.Professores.Find(id);
            }

            public void InsertProfessor(Professor professor)
            {
                try
                {
                    _context.Professores.Add(professor);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void UpdateProfessor(Professor professor)
            {
                try
                {
                    _context.Entry(professor).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void DeleteProfessor(Professor professor)
            {
                try
                {
                    _context.Set<Professor>().Remove(professor);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    
}
