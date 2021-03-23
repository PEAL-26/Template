using AutoMapper;
using $safeprojectname$.ViewModels;
using $safeprojectname$.Domain.Entidades;

namespace $safeprojectname$.AutoMapper
{
    public class DominioParaViewModelMapeamentoProfile : Profile
    {
        public DominioParaViewModelMapeamentoProfile()
        {
            CreateMap<Exemplo, ExemploViewModel>();
        }
    }
}
