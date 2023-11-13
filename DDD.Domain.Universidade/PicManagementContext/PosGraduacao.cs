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
        public string IdPesquisador { get; set; }
        public Projeto ProjetoId { get; set; }
    }
}
