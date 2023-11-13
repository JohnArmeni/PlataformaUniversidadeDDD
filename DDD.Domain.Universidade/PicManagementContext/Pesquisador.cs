using DDD.Domain.Universidade.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.PicManagementContext
{
    public enum TituloEnum
    {
        PosGraduado,
        Mestrado,
        Doutorado
    }

    public class Pesquisador : User
    {
        public TituloEnum Titulo { get; set; }
        public IList<Projeto> Projetos { get; set; }
    }
}
