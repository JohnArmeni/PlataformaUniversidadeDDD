using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Repositories
{
    public class ProjetoRepositorySqlServer : IProjetoRepository
    {
        private readonly SqlContext _context;

        public ProjetoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Projeto GetProjetoById(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void insertProjeto(Projeto projeto)
        {

            try
            {
                _context.Projetos.Add(projeto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //exception
            }
        }

    }
}
