using $safeprojectname$.Domain.Entidades;
using $safeprojectname$.Domain.Interfaces;
using $safeprojectname$.Configuracoes;

namespace $safeprojectname$.Repositorios
{
    public class ExemploRepositorio : GenericoRepositorio<Exemplo>, IExemploRepoitorio
    {
        public ExemploRepositorio(ContextoDatabase contextoDatabase):base(contextoDatabase)
        {

        }
    }
}
