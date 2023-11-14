using DDD.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServiceSer
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
