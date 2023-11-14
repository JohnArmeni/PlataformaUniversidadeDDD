using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using DDD.Universidade.Application.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.ApplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesquisadorController : ControllerBase
    {
        readonly IPesquisadorRepository _pesquisadorRepository;
        readonly ApplicationServiceBoletim _boletimService;

        public PesquisadorController(IPesquisadorRepository PesquisadorRepository, ApplicationServiceBoletim applicationServiceBoletim)
        {
            _pesquisadorRepository = PesquisadorRepository;
            _boletimService = applicationServiceBoletim;
        }

        [HttpGet("{id}")]
        public ActionResult<Pesquisador> GetById(int id)
        {
            return Ok(_pesquisadorRepository.GetPesquisadorById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Pesquisador> CreatePesquisador(Pesquisador Pesquisador)
        {
            if (Pesquisador.Nome.Length < 3 || Pesquisador.Nome.Length > 30)
            {
                return BadRequest("Nome deve ser maior que 3 e menor que 30 caracteres.");
            }
            _pesquisadorRepository.InsertPesquisador(Pesquisador);
            return CreatedAtAction(nameof(GetById), new { id = Pesquisador.UserId }, Pesquisador);
        }

    }
}
