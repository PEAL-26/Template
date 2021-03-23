using Microsoft.Extensions.DependencyInjection;
using Template.Application.Aplicacoes;
using Template.Application.AutoMapper;
using Template.Application.Interfaces;
using Template.Domain.Interfaces;
using Template.Domain.Servicos.Exempolos;
using Template.Infra.Data.Configuracoes;
using Template.Infra.Data.Interfaces;
using Template.Infra.Data.Repositorios;
using Template.Infra.Data.UnitOfWork;

namespace Template.CrossCutting.IoC
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
