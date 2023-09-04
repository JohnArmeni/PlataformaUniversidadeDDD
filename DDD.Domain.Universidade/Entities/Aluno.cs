using DDD.Domain.Universidade.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.Entities
{
    public class Aluno
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [NotMapped]
        public string Email { get; set; }
        [NotMapped]
        public DateTime DataCadastro { get; set; }
        [NotMapped]
        public bool Ativo{ get; set; }

       

        public List<Disciplina>? Disciplinas { get; set; }
    }


}
