using DDD.Domain.Universidade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Universidade.Application.Service
{
    public class ApplicationServiceProjeto
    {
        readonly PosGraduacaoService _posGraduacaoService;

        public ApplicationServiceProjeto(PosGraduacaoService posGraduacaoService)
        {
            _posGraduacaoService = posGraduacaoService;
        }

        public void GerarPosGraduacao(int idProjeto, int idPesquisador)
        {
            var PosGraduacao = _posGraduacaoService.cadastrarPosGraduacao(idProjeto, idPesquisador);
            if (PosGraduacao)
            {
                //Enviar email
            }

        }
    }
}