using DDD.Domain.Universidade.Entities;
using DDD.Infra.MemoryDB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DDD.Universidade.ApplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        readonly IAlunoRepository _alunoRepository;
        readonly IDisciplinaRepository _disciplinaRepository;

        public AlunoController(IAlunoRepository alunoRepository, IDisciplinaRepository disciplinaRepository)
        {
            _alunoRepository = alunoRepository;
            _disciplinaRepository = disciplinaRepository;
        }


        [HttpGet]
        public ActionResult<List<Aluno>> Get()
        {
            return Ok(_alunoRepository.GetAlunos());
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> GetById(int id)
        {
            return Ok(_alunoRepository.GetAlunoById(id));
        }

        [HttpPost]
        public ActionResult<Aluno> CreateAluno(Aluno aluno)
        {
            //Validação
            if (aluno.Nome.Length < 3 || aluno.Nome.Length > 30)
            {
                return BadRequest("Nome precisa ser maior que 3 ou menor que 30 caracteres.");
            }

            _alunoRepository.InsertAluno(aluno);
            return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Aluno aluno)
        {
            try
            {
                if (aluno == null)
                {
                    return BadRequest();
                }
                _alunoRepository.UpdateAluno(aluno);
                return Ok("Aluno atualizado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]

        //public ActionResult UpdateDisciplina([FromBody] Aluno Id, Disciplina DisciplinaId)
        //{
        //    var disciplinas = _disciplinaRepository.Find();
        //    var discId = _disciplinaRepository.GetDisciplinaById(id);
        //    return Ok();
        //}

        [HttpDelete]
        public ActionResult Delete([FromBody] Aluno aluno)
        {
            try
            {
                if (aluno == null)
                {
                    return BadRequest();
                }
                _alunoRepository.DeleteAluno(aluno);
                return Ok("Aluno deletado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
