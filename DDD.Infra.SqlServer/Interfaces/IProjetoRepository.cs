using DDD.Domain.Universidade.PicManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Interfaces
{
    public interface IProjetoRepository
    {
        public Projeto GetProjetoById(int id);

        public void insertProjeto(Projeto projeto);

    }
}
