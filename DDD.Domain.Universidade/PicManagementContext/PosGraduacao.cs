using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.PicManagementContext
{
    public class PosGraduacao
    {
        public int IdPos { get; set; }
        public int IdPesquisador { get; set; }
        public int ProjetoId { get; set; }
    }
}
