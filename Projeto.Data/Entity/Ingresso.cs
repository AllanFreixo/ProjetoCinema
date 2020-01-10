using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entity
{
    public class Ingresso
    {
        public int IdIngresso { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataSessao { get; set; }
        public string SalaCinema { get; set; }
        public int IdCliente { get; set; }
        public int IdFilme { get; set; }

        public Filme Filme { get; set; }
        public Cliente Cliente { get; set; }

    }
}
