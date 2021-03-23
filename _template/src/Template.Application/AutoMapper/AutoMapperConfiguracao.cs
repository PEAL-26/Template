using AutoMapper;

namespace $safeprojectname$.AutoMapper
{
    public class AutoMapperConfiguracao : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
              {
                  ps.AddProfile(new DominioParaViewModelMapeamentoProfile());
                  ps.AddProfile(new ViewModelParaDominioMapeamentoProfile());
              });
        }
    }
}
