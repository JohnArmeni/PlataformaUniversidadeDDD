using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.Services
{
    public class PosGraduacaoService
    {
        readonly IPosGraduacaoRepository _posGraduacaoRepository;
        readonly IProjetoRepository _projetoRepository;
        readonly IPesquisadorRepository _pesquisadorRepository;

        public PosGraduacaoService(IPosGraduacaoRepository posGraduacaoRepository, IProjetoRepository projetoRepository, IPesquisadorRepository pesquisadorRepository)
        {

            _posGraduacaoRepository = posGraduacaoRepository;
            _pesquisadorRepository = pesquisadorRepository;
            _projetoRepository = projetoRepository;

        }


        public bool cadastrarPosGraduacao(int idProjeto, int idPesquisador)
        {
            try
            {
                var projeto = _projetoRepository.GetProjetoById(idProjeto);
                if (projeto.DuracaoProjeto >= 1)
                {
                    var pesquisador = _pesquisadorRepository.GetPesquisadorById(idPesquisador);
                    if (pesquisador.Titulo != TituloEnum.PosGraduado)
                    {
                        if (projeto != null)
                        {
                            _posGraduacaoRepository.InsertPosGraduacao(projeto.ProjetoId, idPesquisador);
                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                throw;
            }


        }

    }
}
