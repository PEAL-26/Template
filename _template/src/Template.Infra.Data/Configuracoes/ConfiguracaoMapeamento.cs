using Flunt.Notifications;
using $safeprojectname$.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace $safeprojectname$.Configuracoes
{
    public static class ConfiguracaoMapeamento
    {
        public static void AplicarConfiguracao(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            //Pega todas as classes que estão implementando a interface IMapping
            var typesToMapping = (from x in Assembly.GetExecutingAssembly().GetTypes()
                                  where x.IsClass && typeof(IMapeamento).IsAssignableFrom(x)
                                  select x).ToList();

            foreach (var mapping in typesToMapping)
            {
                dynamic mappingClass = Activator.CreateInstance(mapping);
                modelBuilder.ApplyConfiguration(mappingClass);
            }
        }
    }
}
