using DDD.Domain.Universidade.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Interfaces
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> GetDisciplinas();
        public Disciplina GetDisciplinaById(int id); //READ
        public void InsertDisciplina(Disciplina disciplina); //CREATE
        public void UpdateDisciplina(Disciplina disciplina); //UPDATE
        public void DeleteDisciplina(Disciplina disciplina); //DELETE
    }
}
