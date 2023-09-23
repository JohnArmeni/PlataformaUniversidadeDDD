using DDD.Domain.Universidade.UserManagementContext;
using DDD.Domain.Universidade.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.SecretariaManagementContext
{
    public class Aluno : User
    {

        public IList<Matricula> Matricula { get; set; }
    }


}
