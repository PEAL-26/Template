using Microsoft.Extensions.DependencyInjection;
using $safeprojectname$.Application.Aplicacoes;
using $safeprojectname$.Application.AutoMapper;
using $safeprojectname$.Application.Interfaces;
using $safeprojectname$.Domain.Interfaces;
using $safeprojectname$.Domain.Servicos.Exempolos;
using $safeprojectname$.Infra.Data.Configuracoes;
using $safeprojectname$.Infra.Data.Interfaces;
using $safeprojectname$.Infra.Data.Repositorios;
using $safeprojectname$.Infra.Data.UnitOfWork;

namespace $safeprojectname$
{
    public class NativeInjectorMapping
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ContextoDatabase>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddSingleton(AutoMapperConfiguracao.RegisterMappings().CreateMapper());
            service.AddScoped(typeof(IGenericoRepositorio<>), typeof(GenericoRepositorio<>));

            service.AddScoped<IExemploApp, ExemploApp>();
            service.AddScoped<IExemploServico, ExemploServico>();
            service.AddScoped<IExemploRepoitorio, ExemploRepositorio>();


        }
    }
}
