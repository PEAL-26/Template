using AutoMapper;
using $safeprojectname$.ViewModels;
using $safeprojectname$.Domain.Entidades;

namespace $safeprojectname$.AutoMapper
{
    public class ViewModelParaDominioMapeamentoProfile : Profile
    {
        public ViewModelParaDominioMapeamentoProfile()
        {
            CreateMap<ExemploViewModel, Exemplo>();
        }
    }
}
