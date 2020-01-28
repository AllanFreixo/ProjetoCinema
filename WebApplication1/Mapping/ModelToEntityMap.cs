using Projeto.Data.Entity;
using Projeto.Service.Model.Cliente;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Service.Model.Filme;
using Projeto.Service.Model.Ingresso;

namespace Projeto.Service.Mapping
{
    public class ModelToEntityMap : Profile
    {
        
        public ModelToEntityMap()
        {
            CreateMap<ClienteAlterarModel, Cliente>();
            CreateMap<ClienteCadastroModel, Cliente>();

            CreateMap<FilmeAlterarModel, Filme>();
            CreateMap<FilmeCadastroModel, Filme>();

            CreateMap<IngressoEdicaoModel, Ingresso>();
            CreateMap<IngressoCadastroModel, Ingresso>();

        }
    }
}
