﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Cliente: Pessoa
    {
        public int idCliente { get; set; }
        public string profissaoCliente { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}
