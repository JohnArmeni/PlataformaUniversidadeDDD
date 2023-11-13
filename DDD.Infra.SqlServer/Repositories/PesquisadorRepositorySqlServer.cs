using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Repositories
{
    public class PesquisadorRepositorySqlServer : IPesquisadorRepository
    {
        private readonly SqlContext _context;

        public PesquisadorRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Pesquisador GetPesquisadorById(int id)
        {
            return _context.Pesquisadores.Find(id);
        }

        public void insertPesquisador(Pesquisador pesquisador)
        {
            try
            {
                _context.Pesquisadores.Add(pesquisador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //exception
            }
        }

    }
}
