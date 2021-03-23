using Template.Infra.Data.Configuracoes;
using Template.Infra.Data.Interfaces;
using System.Threading.Tasks;

namespace Template.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextoDatabase _contexto;

        public UnitOfWork(ContextoDatabase contexto) => _contexto = contexto;

        public async Task<bool> Commit() => (await _contexto.SaveChangesAsync()) > 0;

        public void Dispose() => _contexto.Dispose();

        public Task Rollback() => Task.CompletedTask;
    }
}
