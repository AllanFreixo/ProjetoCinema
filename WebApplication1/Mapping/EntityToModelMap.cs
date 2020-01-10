using AutoMapper;
using Projeto.Data.Entity;
using Projeto.Service.Model.Cliente;
using Projeto.Service.Model.Filme;
using Projeto.Service.Model.Ingresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service.Mapping
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Cliente, ClienteConsultaModel>();
            CreateMap<Filme, FilmeConsultaModel>();
            CreateMap<Ingresso, IngressoConsultaModel>();
        }

    }
}
