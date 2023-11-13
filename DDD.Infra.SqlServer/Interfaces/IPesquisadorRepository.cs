using DDD.Domain.Universidade.PicManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Interfaces
{
    public interface IPesquisadorRepository
    {
        public Pesquisador GetPesquisadorById(int id);

        public void InsertPesquisador(Pesquisador pesquisador);

    }
}
