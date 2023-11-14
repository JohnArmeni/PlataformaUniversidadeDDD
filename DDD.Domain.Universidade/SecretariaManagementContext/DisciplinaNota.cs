using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.SecretariaManagementContext
{
    public class DisciplinaNota
    {
        public int IdDisciplina { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Nota { get; set; }
    }
}
