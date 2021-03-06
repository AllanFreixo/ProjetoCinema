﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service.Model.Filme
{
    public class FilmeAlterarModel
    {
        [Required]
        public int IdFilme { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Sinopse { get; set; }
    }
}
