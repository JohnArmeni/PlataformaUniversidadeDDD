using DDD.Domain.Universidade.SecretariaManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Interfaces
{
    public interface IProfessorRepository
    {
        public List<Professor> GetProfessores();
        public Professor GetProfessorById(int id); //READ
        public void InsertProfessor(Professor professor); //CREATE
        public void UpdateProfessor(Professor professor); //UPDATE
        public void DeleteProfessor(Professor professor); //DELETE
    }
}
