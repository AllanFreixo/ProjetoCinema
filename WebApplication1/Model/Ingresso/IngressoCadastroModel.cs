using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service.Model.Ingresso
{
    public class IngressoCadastroModel
    {
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public DateTime DataSessao { get; set; }
        [Required]
        public string SalaCinema { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdFilme { get; set; }
    }
}

