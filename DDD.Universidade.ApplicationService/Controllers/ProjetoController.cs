using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.ApplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        readonly IProjetoRepository _projetoRepository;

        public ProjetoController(IProjetoRepository ProjetoRepository)
        {
            _projetoRepository = ProjetoRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Projeto> GetProjetoById(int id)
        {
            return Ok(_projetoRepository.GetProjetoById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Projeto> insertProjeto(Projeto projeto)
        {
            if (projeto.NomeProjeto.Length < 3 || projeto.NomeProjeto.Length > 30)
            {
                return BadRequest("Nome deve ser maior que 3 e menor que 30 caracteres.");
            }
            _projetoRepository.InsertProjeto(projeto);
            return CreatedAtAction(nameof(GetProjetoById), new { id = projeto.ProjetoId }, projeto);
        }

    }
}
