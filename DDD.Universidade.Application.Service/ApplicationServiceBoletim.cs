using DDD.Domain.Universidade.SecretariaManagementContext;
using DDD.Domain.Universidade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Universidade.Application.Service
{
    public class ApplicationServiceBoletim
    {
        readonly BoletimService _boletimService;

        public ApplicationServiceBoletim(BoletimService boletimService)
        {
            _boletimService = boletimService;
        }

        public void GerarBoletim(List<DisciplinaNota> disciplinaNotas, int idAluno)
        {

            var matriculaEfetuada = _boletimService.GerarBoletim(disciplinaNotas, idAluno);
            if (matriculaEfetuada)
            {
                //Enviar email
            }
        }

    }
}
