using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EP.CursoMvc.Domain.Entities;
using EP.CursoMvc.Application.ViewModels;

namespace EP.CursoMvc.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<ClienteViewModel, Cliente>();
                x.CreateMap<ClienteEnderecoViewModel, Cliente>();
                x.CreateMap<EnderecoViewModel, Endereco>();
                x.CreateMap<ClienteEnderecoViewModel, Endereco>();
            });
        }

        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }
    }
}
