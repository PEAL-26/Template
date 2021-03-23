using AutoMapper;
using Template.Application.ViewModels;
using Template.Domain.Entidades;

namespace Template.Application.AutoMapper
{
    public class DominioParaViewModelMapeamentoProfile : Profile
    {
        public DominioParaViewModelMapeamentoProfile()
        {
            CreateMap<Exemplo, ExemploViewModel>();
        }
    }
}
