using AutoMapper;
using EP.CursoMvc.Application.ViewModels;
using EP.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Cliente, ClienteViewModel>();
                x.CreateMap<Cliente, ClienteEnderecoViewModel>();
                x.CreateMap<Endereco, EnderecoViewModel>();
                x.CreateMap<Endereco, ClienteEnderecoViewModel>();
            });
        }

        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
    }
}
