using AutoMapper;
using Template.Application.ViewModels;
using Template.Domain.Entidades;

namespace Template.Application.AutoMapper
{
    public class ViewModelParaDominioMapeamentoProfile : Profile
    {
        public ViewModelParaDominioMapeamentoProfile()
        {
            CreateMap<ExemploViewModel, Exemplo>();
        }
    }
}
