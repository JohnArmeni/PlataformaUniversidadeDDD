using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using DDD.Universidade.Application.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.ApplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosGraduacaoController : ControllerBase
    {
        readonly IPosGraduacaoRepository _posGraduacaoRepository;
        readonly ApplicationServiceProjeto _posGraduacaoService;

        public PosGraduacaoController(IPosGraduacaoRepository posGraduacaoRepository, ApplicationServiceProjeto applicationServiceProjeto)
        {
            _posGraduacaoRepository = posGraduacaoRepository;
            _posGraduacaoService = applicationServiceProjeto;
        }

        [HttpGet("{id}")]
        public ActionResult<PosGraduacao> GetPosGraduacaoById(int id)
        {
            return Ok(_posGraduacaoRepository.GetPosGraduacaoById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("criarProjeto")]
        public void CreatePosGraduacao(int idProjeto, int idPesquisador)
        {
            _posGraduacaoService.GerarPosGraduacao(idProjeto, idPesquisador);

        }

    }
}
