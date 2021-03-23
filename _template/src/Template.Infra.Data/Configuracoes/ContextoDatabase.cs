using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace $safeprojectname$.Configuracoes
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase() { }

        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            ConfiguracaoMapeamento.AplicarConfiguracao(modelBuilder);
            ConfiguracaoSeeds.AplicarConfiguracao(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.MySQLConfiguration();

            base.OnConfiguring(optionsBuilder);
        }


    }
}
