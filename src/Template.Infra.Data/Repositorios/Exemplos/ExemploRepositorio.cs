using Template.Domain.Entidades;
using Template.Domain.Interfaces;
using Template.Infra.Data.Configuracoes;

namespace Template.Infra.Data.Repositorios
{
    public class ExemploRepositorio : GenericoRepositorio<Exemplo>, IExemploRepoitorio
    {
        public ExemploRepositorio(ContextoDatabase contextoDatabase):base(contextoDatabase)
        {

        }
    }
}
