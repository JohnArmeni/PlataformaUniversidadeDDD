﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Universidade.PicManagementContext
{
    public class Projeto 
    {
        public int ProjetoId { get; set; }
        public string NomeProjeto { get; set; }
        public string DescricaoProjeto { get; set; }
        public int DuracaoProjeto { get; set; }
    }
}
