using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entity
{
    public class Filme
    {
        public int IdFilme { get; set; }
        public string Titulo { get; set; }
        public string Genero{ get; set; }
        public string Sinopse { get; set; }

        public List<Ingresso> Ingresso { get; set; }
    }
}
