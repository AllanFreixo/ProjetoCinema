using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entity
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }


        public List<Ingresso> Ingresso { get; set; }


    }
}
