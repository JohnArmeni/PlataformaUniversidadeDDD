using DDD.Domain.Universidade.PicManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Interfaces
{
    public interface IPosGraduacaoRepository
    {
        public PosGraduacao InsertPosGraduacao(int idProjeto, int idPesquisador);

        public PosGraduacao GetPosGraduacaoById(int idProjeto);

    }
}
