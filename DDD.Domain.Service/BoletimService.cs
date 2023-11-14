using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DDD.Domain.Service
{
    public class BoletimService
    {
        readonly IMatriculaRepository _matriculaRepository;
        readonly IAlunoRepository _alunoRepository;

        public BoletimService(IMatriculaRepository matriculaRepository, IAlunoRepository alunoRepository)
        {
            _matriculaRepository = matriculaRepository;
            _alunoRepository = alunoRepository;
        }



        /// <summary>
        /// Ao gerar o boletim devemos fazer um check para verificar
        /// se cada uma das disciplinas a serem geradas no boletim
        /// de fato está vinculada para aquele aluno e Disponível 
        /// </summary>
        /// <param name="disciplinaNotas"></param>
        /// <returns></returns>
        public bool GerarBoletim(List<DisciplinaNota> disciplinaNotas, int idAluno)
        {
            try
            {
                Boletim boletim = new Boletim();
                boletim.Notas = new Dictionary<int, decimal>();
                var aluno = _alunoRepository.GetAlunoById(idAluno);
                var disciplinasMatriculadas = _matriculaRepository.GetMatriculasPorAluno(aluno);
                BoletimPersistence boletimPersistence = new BoletimPersistence();

                foreach (var item in disciplinaNotas)
                {
                    var teste = disciplinasMatriculadas.FirstOrDefault(x => x.DisciplinaId == item.IdDisciplina);
                    if (teste != null)
                    {
                        boletimPersistence.Aluno = aluno;
                        boletimPersistence.DisciplinaId = item.IdDisciplina;
                        boletimPersistence.Nota = item.Nota;
                        //boletim.Notas.Add(item.IdDisciplina, item.Nota);
                    }
                    _alunoRepository.PersistirBoletim(boletimPersistence);
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

