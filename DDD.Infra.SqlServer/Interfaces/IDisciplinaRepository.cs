using DDD.Domain.Universidade.SecretariaManagementContext;

namespace DDD.Infra.SqlServer.Interfaces
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
